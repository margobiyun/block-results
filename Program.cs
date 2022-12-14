
String[] Filter(String[] input) {
    int maxSymbols = 3;
    int count = 0;
    for (int i = 0; i < input.Length; i++) {
        if (input[i].Length <= maxSymbols) {
            count++;
        }
    }
    String[] output = new String[count];
    int j = 0;
    for (int i = 0; i < input.Length; i++) {
        if (input[i].Length <= maxSymbols) {
            output[j++] = input[i];
        }
    }
    return output;
}

String[] input = new String[]{"hello", "2", ":-)"};
String[] output = Filter(input);
Console.WriteLine("[\"{0}\"] -> [\"{1}\"]", string.Join("\", \"", input), string.Join("\", \"", output));

input = new String[]{"Russia", "Denmark", "Kazan"};
output = Filter(input);
Console.WriteLine("[\"{0}\"] -> [\"{1}\"]", string.Join("\", \"", input), string.Join("\", \"", output));
