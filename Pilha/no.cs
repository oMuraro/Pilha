// NÓ PADRÃO

public class No{
    public int valor;
    public No prox;

    public No(int valor){
        this.valor = valor;
        this.prox = null;
    }
}



//NÓ PARA DOCUMENTOS
// public class No{

//     public Documentos documento;

//     public No prox;

//     public No(string nome, string extensao, int tamanho){
//         this.documento = new Documentos(nome, extensao, tamanho);
//         this.prox = null;
//     }
// }