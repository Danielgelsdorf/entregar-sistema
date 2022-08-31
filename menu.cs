public class Menu: Cadastro
{    
        List<Cadastro>lista=new List<Cadastro>{};

public System.Collections.Generic.List<Cadastro>   cadastrar(){
    Cadastro Produto=new Cadastro();
    Console.WriteLine("digite o nome do produto");
    Produto.categoria=Console.ReadLine();
    Console.WriteLine("digite a categoria do produto.");
    Produto.scategoria=Console.ReadLine();
    Console.WriteLine("digite a quantidade do produto");
    Produto.quantidade=Console.ReadLine();
    Console.WriteLine("digite o presso de compra do produto");
    Produto.precoCompra=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("digite onde vai está o produto");
    Produto.local=Console.ReadLine();
    Console.WriteLine("digite quantos % deseja ganhar na venda.");
    Produto.porcentagemGanho=Convert.ToInt32(Console.ReadLine());
    Produto.precoFinal=((Produto.precoCompra/100)*Produto.porcentagemGanho)+Produto.precoCompra;
    Console.WriteLine("o produto vai ficar disponível para venda\n digite s: para sim \n e n: para não.");
    string i;
    switch(i=Convert.ToString(Console.ReadLine())){
        case"s":
            Produto.status=true;
            break;
        case"n":
            Produto.status=false;
            break;
        default:
            Console.WriteLine("opção errada, digite outra!");
            break;
        }
    lista.Add(Produto);
    return lista;
}
public void listar (List<Cadastro> lista){
    int i=0;
foreach (Cadastro cadastro in lista){
Console.WriteLine("nome do produto: "+cadastro.categoria);
Console.WriteLine("categoria do produto:"+cadastro.scategoria);
cadastro.precoCompra=Math.Round(cadastro.precoCompra,2);
cadastro.precoFinal=Math.Round(cadastro.precoFinal,2);
Console.WriteLine("quantidade do produto: "+cadastro.quantidade);
Console.WriteLine("presso de compra: R$"+cadastro.precoCompra);
Console.WriteLine("preço de venda: R$"+cadastro.precoFinal);
Console.WriteLine("local do produto"+cadastro.local);
if (lista[i].status==true){
    Console.WriteLine("produto disponível");
}
if(lista[i].status==false){
    Console.WriteLine("produto indisponível");
}
i=i+1;
}
}

public System.Collections.Generic.List<Cadastro> auterar(List<Cadastro> lista){
    Console.WriteLine("aqui você pode mudar o estatos do produto");
    int i;
    i=0;
    foreach(Cadastro cadastro in lista){
        Console.WriteLine("número do produto: "+i+" nome do produto: "+cadastro.categoria);
        i=i+1;
    }
    Console.WriteLine("digite o número do produto");
    int j,k;
    j=Convert.ToInt32(Console.ReadLine());
    k=lista.Count();
    if (j>=k){
        Console.WriteLine("produto não disponível para alterar");
    }
    else{
    if(lista[j].status==true){
        lista[j].status=false;
        Console.WriteLine(lista[j].categoria+"agora não disponível");
        return lista;
    }
    if(lista[j].status==false){
        lista[j].status=true;
        Console.WriteLine(lista[j].categoria+$", agora disponível");
        return lista;
    }
    }
    return lista;
}
public void menu(){
    List<Cadastro> lista=new List<Cadastro>{};
        string i="a";
    do{
    Console.WriteLine("digite: c para cadastrar produtos");
    Console.WriteLine("digite l: para listar itens cadastratos");
    Console.WriteLine("digite m: para muudar o status do produto");
    Console.WriteLine("digite s: para sair.");
    switch(i=Console.ReadLine()){
        case "c":
            lista=cadastrar();
            break;
        case "l":
        int con=lista.Count();
            if (con==0){
                Console.WriteLine("lista vasia");
            }
            else{
                listar(lista);
            }
            break;
        case"m":
            lista=auterar(lista);
            break;
        case"s":
            Console.WriteLine("saindo");
            i="s";
            break;
        default:
        Console.WriteLine("opção errada, por favor digite outra!");
        break;
    }
}while (i!="s");
}
}