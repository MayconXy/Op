# Título: MiniZoo 

## Descrição do Projeto
Neste teste, vais trabalhar com um projeto C# existente chamado "MiniZoo". O projeto simula um sistema simples de gestão de animais de um mini-zoo. A tua tarefa é implementar funcionalidades adicionais, criar uma nova subclasse de animal e refatorar algum código existente para usar polimorfismo e encapsulamento.

O projeto existente é composto pelas seguintes classes:
- Animal
- Mamífero : Animal
- Réptil : Animal
- MiniZoo

## Tarefas
1. Implementa as seguintes classes adicionais de animais, herdando das classes base apropriadas:
   - Leão : Mamífero
   - Cobra : Réptil
2. Adiciona propriedades específicas a cada nova classe de animal existente:
   - Leão: TamanhoDoGrupo (int)
   - Cobra: Comprimento (double)
3. Na classe Animal, cria um método abstrato chamado EmitirSom() : string.
4. Substitui o método EmitirSom() em cada subclasse de animal, retornando um som único para cada animal.
5. Na classe MiniZoo, adiciona um método que aceite um objeto Animal como parâmetro e o adicione a uma lista de animais:
   - AdicionarAnimal(Animal animal) : void
6. Refatora a classe MiniZoo existente para usar polimorfismo:
   - Implementa um método chamado EmitirSomDeTodosOsAnimais() : void que percorre a lista de animais e imprime o som que cada animal emite
7. Implementa um método que imprime todos os animais do MiniZoo:
   - Implementa um método chamado ImprimirTodosOsAnimais() : void que percorre a lista de animais e imprime o nome, tipo {animal.GetType().Name}, e propriedades de cada animal
8. No método Main, cria algumas instâncias de cada classe de animal, adiciona-as ao MiniZoo e, em seguida, chama os métodos EmitirSomDeTodosOsAnimais() e ImprimirTodosOsAnimais() para demonstrar polimorfismo e encapsulamento.
