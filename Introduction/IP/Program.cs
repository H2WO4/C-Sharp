Console.Write("Enter an IP address: ");
String input = Console.ReadLine() ?? "";

int useless;
// Regex.Match(input, @"^(?:(?:1?\d?\d|2[0-4]\d|25[0-5])\.){3}(?:1?\d?\d|2[0-4]\d|25[0-5])$").Success
List<int> ipElems = input.Split('.').Select((el) => (int.TryParse(el, out useless) ? int.Parse(el): -1)).ToList<int>();

if (ipElems.All((el) => (el >= 0 && el <= 255)) && ipElems.Count == 4) {
	if (ipElems[0] == 10 ||
		ipElems[0] == 172 && ipElems[1] >= 16 && ipElems[1] <= 31 ||
		ipElems[0] == 192 && ipElems[1] == 168) {
		Console.WriteLine("Private IP address");
	}
	else {
		Console.WriteLine("Non-private IP address");
	}
}
else {
	Console.WriteLine("Not a valid IP address");
}