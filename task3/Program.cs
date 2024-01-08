int num = 10;
int first = num / 10;
int second = num % 10;
    if(first > second)
      Console.WriteLine(first + " является большей цифрой.");
    else if(second > first)
      Console.WriteLine(second + " является большей цифрой.");
    else
      Console.WriteLine("Обе цифры равны по величине.");


    