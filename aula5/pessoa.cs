// class Pessoa{
//     public string nome;
//     public int idade;
//     public string sexo;

//     public void defineNome(string novoNome)
//     {
//         if(nome != null){
//             nome = novoNome;
//         }
//     }

        
//     public string retornaNome()
//     {
//         return nome;
//     }

//}

class Livro{
    public string titulo;
    public string autor;
    public int ano;
    public int paginas;

    public void Informacoes()
    {
        Console.WriteLine($"Titulo: {titulo}\nAutor: {autor}\nAno: {ano}\nQuantidade de páginas: {paginas}");
    }
    public bool TemMaisDe300Paginas()
    {
        return paginas > 300;
    }
}