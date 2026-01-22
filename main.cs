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

Console.WriteLine("Hello World "+foo(1000));