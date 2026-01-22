Console.WriteLine("Hello World Again!");


//Stack<int> = new Stack<int>(); //Built in implementation

/*Create a class MyStack that provides the standard stack operations:
void push(T), T pop() and T peek()
You can make it an integer stack if you want

Stack: LIFO*/
int bar(int i){
    return foo(i-2)+1;
}


int foo(int i){
    if (i>1)
        return bar(i+1);
    return 0;
}

Console.WriteLine("Hello World "+foo(20000));

//define a MyStack class

//use it

MyStack m = new MyStack();

m.push(4);
m.push(5);
m.push(2);
Console.WriteLine(m.pop());
m.push(4);
m.push(7);
m.push(2);
while (m.size() > 0)
{
    Console.WriteLine(m.pop());
}
/*This should output:
2
2
7
4
5
4*/

internal class MyStack
{
}