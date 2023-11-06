
//First

int count=1, sum=0;
while(count<1000){
    sum+=count;
    count+=2;
}

//Second

int[] arr={1,2,3,4,5,6,7,8,9,10};
int max = arr[0], min = arr[0];
for(int i=0; i<arr.Length; i++){
    if(arr[i]>max)
        max=arr[i];
    if(arr[i]<min)
        min=arr[i];
}
System.Console.WriteLine($"min*max={min*max}");

//Third

int num = Convert.ToInt32(Console.ReadLine());
int cnt = 1, fac=1;

if(num==0){
    fac=1;
    System.Console.WriteLine($"{num}! = {fac}");
}
else{
    while(cnt<=num){
        fac*=cnt;
        cnt++;
    }
    System.Console.WriteLine($"{num}! = {fac}");
}
