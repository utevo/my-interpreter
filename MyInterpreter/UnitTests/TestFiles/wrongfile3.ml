
int SumOfThree(int a, int b, int c)
{
    return a + b + c; #test comment 1
}

int main()
{
    int x = ((SumOfThree(1, 2) + 25) * 2) / 4;
    matrix m[4,5];
    x += 5;
    m[2:2, 4:4] = 5;
    m[3:3, 4:4] = 6;
    print(m);
    print (x + SumOfThree(1, 2, 4)); 
    if(x == 5)
        print(x); #test comment 2
    else
        print(-(-x + 1));
    #test comment 3
    x = 0;
    while(x < 10)
        x += 1;
    int i;
    for(i = 0; i < 5; i += 1)
    {
       print(i);         
    }
    return 0;
}