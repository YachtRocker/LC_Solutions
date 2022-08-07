// Leetcode #20 from the Blind75
// Big 0n

string test = "(]";
bool ans;
ans = IsValid(test);

Console.WriteLine(ans);


// Checks top see if parenthesis are valid, each one has a opening and closing
bool IsValid(string s)
{
    
    // create dictionary which is c# version of hashmap
    Dictionary<char, char> dict = new Dictionary<char, char>()
    {
        { ')', '(' },
        { '}', '{' },
        { ']', '[' }
    };

    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        bool keyExists = dict.ContainsKey(c);

        if (keyExists)
        {
            if(stack.Count != 0 && stack.Peek() == dict[c])
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }
        else
        {
            stack.Push(c);
        }
    }

    if (stack.Count == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}