Pilha pilha = new Pilha();
Pilha pilha2 = new Pilha();

pilha.push(1);
pilha.push(2);
pilha.push(3);
pilha.push(5);
pilha.push(4);

pilha2.trocaElementos(pilha);

pilha.imprimir();
Console.WriteLine("///");
pilha2.imprimir();


// pilha.verificaPalindromo();
// pilha.contador();
// pilha.verificaImpar();
// pilha.imprimir();

//TESTE PILHA DOCUMENTOS

// Pilha pilhaDocumentos = new Pilha();

// pilhaDocumentos.push("Marca Texto", "js", 2);
// pilhaDocumentos.push("Sprint 1", "cs", 300);
// pilhaDocumentos.push("God of War", "exe", 20000);

// pilhaDocumentos.pop();

// pilhaDocumentos.search("Sprint 1");

// pilhaDocumentos.imprimir();

