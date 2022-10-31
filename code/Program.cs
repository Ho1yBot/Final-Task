string[] a = {"Sun", "Monday", "Tuersday",
      "Wednesday", "Thirsday", "F", "Saturday"};
Console.Write("[");      
for(int i = 0; i < a.Length; i++){
    int count = 0;
    for(int j = 0; j < a[i].Length; j++){
        
        count = count + 1;
        //Console.Write("Длина" + count);
    }