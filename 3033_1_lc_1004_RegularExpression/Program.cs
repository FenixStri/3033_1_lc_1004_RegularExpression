// Fenix Strickland 113437176
// Regular Expression
// October 4, 2022
//. Any character(except newline character) "he..o"
//^ Starts with "^hello"
//$ Ends with "world$"
//* Zero or more occurrences "aix*"
//+ One or more occurrences "aix+"
//{ } Exactly the specified number of occurrences "al{2}"
//[] A set of characters "[a-m]"
//\ Signals a special sequence (can also be used to escape special characters) "\d"
//| Either or "falls|stays"
//() Capture and group

using System.Text.RegularExpressions;

string testStr = "123abc456789. abcbcc123ABC";
//. \d \D [] ^(means must be at the beginning) $(means must be at the ending) \b finds the block. or space in the string
// ? means the last character is optional
// * means 0,1,2,3, or more
// + means at least one
// {} how many times it can repeat
// () define a group .. start with abc and end with any character inside ()

Regex regex = new Regex(@"abc(c|d|1|2)");
var r = regex.Matches(testStr);

var r2 = regex.Replace(testStr, "***");


Console.ReadKey();
