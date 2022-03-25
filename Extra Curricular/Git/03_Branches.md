# Trabalhando com Branchs

### Branches

- São ramificações/bifurcações do codigo online
- Permite que faça alterações em uma branch separada, manntendo o codigo funcional em uma e o codigo em desenvolvimento em outra
  - Permite que trabalhe em cenarios paralelos
- Permite que junte as braches por meio do Merge
- Uma branch não existe sem um commit, e um commit não existe sem uma branch

### Main/Master

- Antigamente o Git definia o nome "master" para a branch principal, atualmente é possivel decidir e definir um nome especifco à branch principal
- A branch principal é a branch que será exibida por padrão no Repositorio Online
- Sempre se atentar aos comandos que utilizam o nome da branch, como o ``pull`` e ``push``

### HEAD

- É uma Tag que sempre aponta para o utlimo commit de uma Branch
- Caso crie e altere para uma nova branch, a Tag ``HEAD`` acompanhara os ultimos commit dessa nova branch. Entretanto, caso volte à branch antiga, a Tag ``HEAD`` volta para o utlimo commit dessa branch antiga e deixa de estar na nova branch
  - Caso realize um **Merge** entre as Branches, ela pegará o commit com a Tag ``HEAD`` da Branch atual e unirá com o commit com a Tag ``HEAD`` da Branch que está sendo realizado o merge

### Comando Checkout

- Esse comando é utilizado para movimentar entre Branches
  - Quando se saí de uma branch e entra em outra, caso altere algum arquivo e realize o ``git checkout`` para a branch Inicial, os arquivos irão juntos
- ``git checkout -b new-branch``: Move a Area de Trabalho do Git para a Branch ``new-branch``, junto a Flag ``-b` que é responsavel criar uma Nova Branch
  - Ao criar essa Nova Branch, o Historico de Commits da Branch Inicial é mantido

### Comando Merge

- Utilizado para Unir Branches:
  - Entrar na Branch (``git checkout branch``) que irá receber a Branch
  - ``git merge branch-work-something``
  - É possivel que ocorra conflitos. Nesse cenario, é preciso decidir manualmente quais alterações serão mantidas

### Comandos Branch

- ``git branch``: lista as Branches do Repositorio Local
  - A Branch atual será localizada por um (*)
- ``git branch -m new-name-actual-branch``: Altera o nome da Branch atual
- ``git branch -m old-name-branch new-name-branch``: Altera o nome de uma branch especifica
- ``git branch -d name-branch``: Deleta uma Branch Especifica

### Comandos Stash

- ``git stash``: Pega todos os Itens do ``Modified`` e salva eles em uma "caixinha", deixando esses arquivos fora da Area de Trabalho do Git
  - ``Modified``: Arquivos Observados pelo Git que sofreram modificações
- ``git stash save "Mensagem Descrevendo o Stash"``: Pega os Itens do ``Staging Area``/Index e salva eles em uma "caixinha", deixando esses arquivos fora da Area de Trabalho do Git
  - ``Staging Area``/Index: Local dos arquivos após o ``git add``
  - Mais recomendado para Utilizar pois permite que identifique o conteudo por uma mensagem
- ``git stash list``: Lista todos os ``stash`` do Git
  - São Listado dos Mais Recentes para os Mais Antigos
- ``git stash pop [index]``: Por meio do ``index``, permite retornar o conteudo do ``stash`` informado
  - Pode ocorrer conflitos de Arquivos. Caso aconteça, acesse o arquivo que possui o conflito e escolha a alteração manualmente
- ``git stash clear``: Apaga Todos os ``stash``
