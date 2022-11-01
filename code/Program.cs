string[] a = {"Sun", "Monday", "Tuersday",
      "Wednesday", "Thirsday", "F", "Saturday"};
string [] b = new string [a.Length];
Console.Write("[");      
int k = -1;    
for(int i = 0; i < a.Length; i++){
    int count = 0;
    for(int j = 0; j < a[i].Length; j++){
        
        count = count + 1;
        //Console.Write("Длина" + count);
    }
    if (count < 4){
        k++;
        b[k] = a[i];
    }
    
}
for(int i = 0; i < k; i++){
    Console.Write(b[i] + ", ");
}
for(int i = k; i < k+1; i++){
    Console.Write(b[i]);
}
Console.Write("]");