
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt16(Console.ReadLine());

RecursionTotal(n);

void RecursionTotal(int n){
    if(n != 1){

        Console.Write(n + ",");
        RecursionTotal(n - 1);

    }
    else{

         Console.Write(n);
         return;

    }


}

