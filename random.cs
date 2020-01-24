using System;
int ran(int num,int face,int add){
  Random r = new System.Random();
  if(face == 100){
    int tmp = r.Next(1*num,dace*num)+add-1; 
    Console.Write("{}面ダイスを{}回振り{}を足した\n結果は{}\n",face,num,add,tmp)
    return tmp;
  }
  else{
    int tmp = r.Next(1*num,face*num)+add;
    Console.Write("{}面ダイスを{}回振り{}を足した\n結果は{}\n",face,num,add,tmp)
    return tmp;
  }
}
