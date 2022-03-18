var a = new Point();
var b = new Point(3, 5);
var c = new Point(3, 6);
var d = new Point(3, 5);

Console.WriteLine($"{a + b + (-c)} {b == c} {b == d} {Point.Distance(b, c)}");

class Point
{
	private double _x;
	private double _y;

	public double X
	{
		get => this._x;
		set => this._x = value;
	}
	public double Y
	{
		get => this._y;
		set => this._y = value;
	}

	public Point()
	{
		this._x = this._y = 0;
	}
	public Point(double x, double y)
	{
		this._x = x;
		this._y = y;
	}

	public static bool operator ==(Point obj1, Point obj2)
		=> obj1._x == obj2._x && obj1._y == obj2._y;
	
	public static bool operator !=(Point obj1, Point obj2)
		=> obj1._x != obj2._x || obj1._y != obj2._y;

	public override bool Equals(object? other)
		=> other is Point ? this == (Point)other : throw new ArgumentException();

	public static Point operator +(Point obj1, Point obj2)
		=> new Point(obj1._x + obj2._x, obj1._y + obj2._y);

	public static Point operator -(Point obj)
		=> new Point(-obj._x, -obj._y);
	
	public static double Distance(Point obj1, Point obj2)
		=> Math.Sqrt(Math.Pow(obj1._x - obj2._x, 2) + Math.Pow(obj1._y - obj2._y, 2));

	public override string ToString()
		=> $"({this._x}, {this._y})";

	public override int GetHashCode()
		=> HashCode.Combine(_x, _y, X, Y);
}

class Interval
{
	private int _start;
	private int _end;

	public int Start { get => this._start; }
	public int End { get => this._end; }
	public int Length { get => Math.Abs(this._start - this._end); }

	public Interval(int start, int end)
	{
		this._start = start;
		this._end = end;
	}

	public static Interval operator +(Interval obj, int n)
		=> new Interval(obj._start + n, obj._end + n);
	public static Interval operator +(int n, Interval obj)
		=> new Interval(obj._start + n, obj._end + n);
	
	public static Interval operator -(Interval obj, int n)
		=> new Interval(obj._start, obj._end - n);
	public static Interval operator -(int n, Interval obj)
		=> new Interval(obj._start, obj._end - n);
	
	public static Interval operator *(Interval obj, int n)
		=> new Interval(obj._start * n, obj._end * n);
	public static Interval operator *(int n, Interval obj)
		=> new Interval(obj._start * n, obj._end * n);
	
	public static Interval operator >>(Interval obj, int n)
		=> new Interval(obj._start, obj._end + n);
	
	public static Interval operator <<(Interval obj, int n)
		=> new Interval(obj._start + n, obj._end);

	public int this[int n]
	{
		get => n >= 0 && n <= this.Length
				? this._start <= this._end
					? this._start + n 
					: this._start - n
				: throw new IndexOutOfRangeException();
	}
}