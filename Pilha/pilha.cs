//PILHA PADRÃO

public struct Pilha
{
    public No topo;

    public Pilha()
    {
        this.topo = null;
    }

    public Boolean estaVazia()
    {
        if (this.topo == null)
        {
            return true;
        }
        return false;
    }

    public void push(int valor)
    {
        No novoNo = new No(valor);

        if (estaVazia() == true)
        {
            this.topo = novoNo;
        }
        else
        {
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    public No pop()
    {
        No noAtual = this.topo;
        if (estaVazia() == true)
        {
            Console.WriteLine("A lista esta vazia");
        }
        else
        {
            this.topo = this.topo.prox;
        }
        return noAtual;
    }

    public Boolean search(int valor)
    {
        No noAtual = this.topo;

        if (estaVazia() == true)
        {
            Console.WriteLine("A lista esta vazia");
        }
        else
        {
            while (noAtual != null)
            {
                if (noAtual.valor == valor)
                {
                    Console.WriteLine("Elemento existe na lista");
                    return true;
                }
                noAtual = noAtual.prox;
            }
        }
        return false;
    }

    public int contador()
    {
        if (estaVazia() == true)
        {
            Console.WriteLine("A lista esta vazia");
            return 0;
        }
        else
        {
        int cont = 0;
            No noAtual = this.topo;

            while (noAtual != null)
            {
                cont++;
                noAtual = noAtual.prox;
            }
            // Console.WriteLine("A lista possui " + cont + " elementos");
            return cont;
        }
    }

    public void verificaImpar()
    {
        if (estaVazia() == true)
        {
            Console.WriteLine("A lista está vazia");
        }
        else
        {
            int cont = 0;
            No noAtual = this.topo;

            while (noAtual != null)
            {
                if (noAtual.valor % 2 != 0)
                {
                    cont++;
                }
                noAtual = noAtual.prox;
            }
            Console.WriteLine("A quantidade de elementos ímpares é " + cont);
        }
    }

    public void separaNumeros()
    {
        No noAtual = this.topo;
        Pilha pilha2 = new Pilha();
        Pilha pilha3 = new Pilha();

        while (noAtual != null)
        {
            if (noAtual.valor <= 0)
            {
                pilha2.push(noAtual.valor);
            }
            else
            {
                if (noAtual.valor > 0)
                {
                    pilha3.push(noAtual.valor);
                }
            }
            noAtual = noAtual.prox;
        }
        Console.WriteLine("Negativos:");
        pilha2.inverter();
        pilha2.imprimir();
        Console.WriteLine("Positivos:");
        pilha3.inverter();
        pilha3.imprimir();
    }

    public void inverter()
    {
        No noAtual = this.topo;
        Pilha pilha2 = new Pilha();

        while (noAtual != null)
        {
            pilha2.push(noAtual.valor);
            noAtual = noAtual.prox;
        }
        this = pilha2;
    }

    public bool verificaPalindromo()
    {
        No noAtual = this.topo;
        Pilha pilha2 = new Pilha();

        pilha2 = this;
        pilha2.inverter();

        if (this.contador() != pilha2.contador())
        {
            return false;
        }

        No noAtual2 = pilha2.topo;
        while (noAtual != null)
        {
            if (noAtual.valor != noAtual2.valor)
            {
                Console.WriteLine("Não é um palindromo");
                return false;
            }
            noAtual = noAtual.prox;
            noAtual2 = noAtual2.prox;
        }

        Console.WriteLine("É um palindromo");
        return true;
    }

    public void trocaElementos(Pilha pilha){
        No noAtual = pilha.topo;

        while(noAtual != null){
            this.push(noAtual.valor);
            pilha.pop();
            noAtual = noAtual.prox;
        }
        this.inverter();
    }

    public void imprimir()
    {
        No noAtual = this.topo;

        while (noAtual != null)
        {
            Console.WriteLine(noAtual.valor + " -> ");
            noAtual = noAtual.prox;
        }
    }
}



//PILHA DE DOCUMENTOS

// public class Pilha
// {
//     public No topo;

//     public Pilha()
//     {
//         this.topo = null;
//     }

//     public Boolean estaVazia()
//     {
//         if (this.topo == null)
//         {
//             return true;
//         }
//         return false;
//     }

//     public void push(string nome, string extensao, int tamanho)
//     {
//         No novoNo = new No(nome, extensao, tamanho);

//         if (estaVazia())
//         {
//             this.topo = novoNo;
//         }
//         else
//         {
//             novoNo.prox = this.topo;
//             this.topo = novoNo;
//         }
//     }

//     public No pop()
//     {
//         No noAtual = this.topo;
//         if (estaVazia() == true)
//         {
//             Console.WriteLine("A lista está vazia");
//         }
//         else
//         {
//             this.topo = this.topo.prox;
//         }
//         return noAtual;
//     }

//     public Boolean search(string nome)
//     {
//         No noAtual = this.topo;
//         if (estaVazia() == true)
//         {
//             Console.WriteLine("A lista esta vazia");
//         }
//         else
//         {
//             while (noAtual != null)
//             {
//                 if (noAtual.documento.nome == nome)
//                 {
//                     Console.WriteLine("Elemento " + nome + " existe na lista");
//                     return true;
//                 }
//                 noAtual = noAtual.prox;
//             }
//         }
//             return false;
//     }

//     public void imprimir(){
//         No noAtual = this.topo;

//         while(noAtual != null){
//             Console.WriteLine("Nome do Documento: " + noAtual.documento.nome + 
//                               "\nExtensão do Documento: " + noAtual.documento.extensao +
//                               "\nTamanho do Documento: " + noAtual.documento.tamanho + " KB \n↓\n");
//             noAtual = noAtual.prox; 
//         }
//     }
// }