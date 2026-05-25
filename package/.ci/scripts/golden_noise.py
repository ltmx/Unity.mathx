import math

NOISE_SIMPLEX_1_DIV_289 = 0.00346020761245674740484429065744


def floor2(v):
	return (math.floor(v[0]), math.floor(v[1]))


def dot2(a, b):
	return a[0] * b[0] + a[1] * b[1]


def mod289(x):
	if isinstance(x, tuple):
		return tuple(xi - math.floor(xi * NOISE_SIMPLEX_1_DIV_289) * 289 for xi in x)
	return x - math.floor(x * NOISE_SIMPLEX_1_DIV_289) * 289


def permute3(x):
	return mod289(tuple(xi * xi * 34 + xi for xi in x))


def taylor_inv_sqrt3(r):
	return tuple(1.79284291400159 - 0.85373472095314 * ri for ri in r)


def step_scalar(edge, x):
	return 1.0 if x >= edge else 0.0


def snoise2(v):
	c = (0.211324865405187, 0.366025403784439, -0.577350269189626, 0.024390243902439)
	i = floor2((v[0] + dot2(v, (c[1], c[1])), v[1] + dot2(v, (c[1], c[1]))))
	x0 = (v[0] - i[0] + dot2(i, (c[0], c[0])), v[1] - i[1] + dot2(i, (c[0], c[0])))
	i1 = (step_scalar(x0[1], x0[0]), 1.0 - step_scalar(x0[1], x0[0]))
	x1 = (x0[0] + c[0] - i1[0], x0[1] + c[0] - i1[1])
	x2 = (x0[0] + c[2], x0[1] + c[2])
	i = mod289(i)
	p1 = permute3((i[1], i[1] + i1[1], i[1] + 1.0))
	p = permute3((p1[0] + i[0], p1[1] + i[0] + i1[0], p1[2] + i[0] + 1.0))
	m = tuple(max(0.0, 0.5 - d) for d in (dot2(x0, x0), dot2(x1, x1), dot2(x2, x2)))
	m = tuple(mi * mi for mi in m)
	m = tuple(mi * mi for mi in m)
	x = tuple(2.0 * ((pi * c[3]) % 1.0) - 1.0 for pi in p)
	h = tuple(abs(xi) - 0.5 for xi in x)
	ox = tuple(math.floor(xi + 0.5) for xi in x)
	a0 = tuple(x[j] - ox[j] for j in range(3))
	norm = taylor_inv_sqrt3(tuple(a0[j] * a0[j] + h[j] * h[j] for j in range(3)))
	m = tuple(m[j] * norm[j] for j in range(3))
	g = (a0[0] * x0[0] + h[0] * x0[1], a0[1] * x1[0] + h[1] * x1[1], a0[2] * x2[0] + h[2] * x2[1])
	return 130.0 * sum(m[j] * g[j] for j in range(3))


if __name__ == "__main__":
	for pt in [(0.0, 0.0), (1.3, 2.7), (0.5, 0.5), (1.0, 2.0), (12.34, 56.78)]:
		print(f"{pt}: simplex2={snoise2(pt):.9f}")

	def fbm2(v, octaves=3, lac=2.0, gain=0.5):
		total = amp = freq = 1.0
		s = 0.0
		for _ in range(octaves):
			s += amp * snoise2((v[0] * freq, v[1] * freq))
			freq *= lac
			amp *= gain
		return s

	print(f"fbm2(1,2,3)={fbm2((1.0,2.0),3):.9f}")
