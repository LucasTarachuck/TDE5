// Pessoa p1 = new Pessoa();
// p1.nome = "Lucas";
// p1.idade = 18;
// p1.sexo = "Masculino";

// p1.defineNome("Claúdia");

// string nomeObjeto;
// nomeObjeto = p1.retornaNome();


// Console.WriteLine(nomeObjeto);

// // Pessoa p2 = new Pessoa();
// // p2.nome = "Manoel";
// // p2.idade = 23;
// // p2.sexo = "Maculino";

// // Console.WriteLine($"Nome: {p2.nome}\nIdade: {p2.idade}\nSexo: 

Livro livro1 = new Livro();
livro1.titulo = "Chamado de Cthulhu";
livro1.autor = "H. P. Lovecraft";
livro1.ano = 1926;
livro1.paginas = 144;

livro1.Informacoes();
if(livro1.TemMaisDe300Paginas() == true){
    Console.WriteLine("O livro tem mais de 300 páginas");
}
else{
        Console.WriteLine("O livro tem menos de 300 páginas");

}

Livro livro2 = new Livro();
livro2.titulo = "1984";
livro2.autor = "George Orwell";
livro2.ano = 1949;
livro2.paginas = 416;

livro2.Informacoes();

if(livro2.TemMaisDe300Paginas() == true){
    Console.WriteLine("O livro tem mais de 300 páginas");
}
else{
        Console.WriteLine("O livro tem menos de 300 páginas");

}
