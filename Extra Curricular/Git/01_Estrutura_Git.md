# Estrturua e Introdução ao Git e GitHub

## Conteudo

- [Resumo](#resumo)
- [Introdução ao Terminal](#introdução-ao-terminal)
- [Objetos Internos/Sistema Distribuido GIT](#objetos-internossistema-distribuido-git)
- [Estados do Git](#estados-do-git)
- [Comandos](#comandos)
- [Conflitos de Arquivos](#conflitos-de-arquivos)

---

### Resumo

O Git é um software de Versionamento de Codigo, que permite a organização e disponibilização de trabalhos em versões, identificando as alteração ao longo do tempo. Para gerenciar esse versionamento, é possivel utilizar Softwares CLI (Git Bash), em que a interação é feita por meio da Linha de Comando (Terminal) ou Softwares GUI (Git Kraken), que possui uma Interface Grafica para interação

Além disso, ele é um software de Sistema Distribuido, em que seu codigo possui diversas copias, sendo armazenado de forma local em um unico ou varios computadores, e tambem em um Repositorio Online, como no GitHub ou GitLab.

> Termo **"Repositorio"**: Se Trata de uma Pasta que contem o Sistema de Versionamento do Git. Esse sistema é iniciado após executar o ``git init`` no diretorio informado, criando um ``Repositorio Local``

Para que ocorra toda essa organização dos arquivos, é utilizado de um conjunto de Criptografia Hash, chamada SHA1. No Git, esse conjunto de Criptografia é dividido em 3 Objetos:
- Bloob: Representa o Conteudo de um Arquivo em um ``String`` de 40 Caracteres
  - Essa ``String`` muda conforme o conteudo do Arquivo
- Tree: Responsavel pela organização de Diretorios. Ela pode apontar tanto para um conjunto de arquivos (varios bloobs) daquele diretorio, como tambem para outros diretorios (Trees)
- Commit: Organiza toda a informação do Repositorio naquele momento/cenário. Ele encapsula as Trees, que por sua vez contem os Bloobs e/ou outras Trees. É representado por um SHA1 Unico, contendo o Nome do Autor, Horario em que foi Criado e uma Mensagem identificando seu Conteudo.

Por meio desses 3 Objetos, o Git consegue perceber todas as alterações nos arquivos do Repositorio, sejam elas a criação de uma função ou apenas a alteração de uma virgula. Dessa forma, a cada alteração, é possivel organizar o conteudo por meio dos Commits.

Com isso, o Git tambem divide os arquivos (bloobs) em "areas". Com o tempo, conforme é executado comados ou alterações nos arquivos, eles se movimentam nas seguintes areas:
- Untracked: Representa que o arquivo não está sendo "Observado" pelo Git (Provavelmente, não existia no Commit anterior ou o arquivo foi excluido)
- Unmodified: O arquivo é observado pelo Git, mas não houve alterações desde o ultimo Commit
- Modified: O arquivo sofreu alterações, logo, seu SHA1 tambem foi alterado
- Staged: Representa a área em que os arquivos ficam "preparados" para virar um Commit (Ficam nessa area após um ``git add something.ext``)

Como os Repositorios são Disponibilizado tambem de forma Online, é possivel uma pessoa tenha alterado e disponibilizado de forma online, uma mudança na mesma linha em um mesmo arquivo que estava sendo alterado localmente. Para resolver esse conflito, é necessario primeiro fazer um ``git pull`` e verificar se o ``auto-merge`` funcionou. Caso não tenha funcionado, será necessario abrir os arquivos que contem os conflitos e escolher qual alteração será mantida e finalizar fazendo um ``commit`` com a alteração final.

Por fim, alguns comandos importantes no Git são:
- ``git config``: Responsavel por Exibir e Gerenciar as Configurações do Git
- ``git init``: Inicializa um Repositorio Git no Diretorio
- ``git add``: Adiciona os Arquivos na ``Staging Area/Index`` que depois viram Commits
- ``git commit``: Cria um Commit (Encapsulado de SHA1 com os dados daquele Repositorio)
- ``git remote``: Define as configurações com o Repositorio Online (GitHub, GitLab)
- ``git push``: Envia os Commits para o Repositorio Online
- ``git pull``: Baixa as atualizações do Repositorio Online
- ``git clone``: Baixa/Clona todos os Commits do Repositorio Online, criando a estrutura e trazendo os arquivos existentes

---

### Introdução ao Terminal

- GUI: Software que permite a Interação com a Interface Grafica
- CLI: Software que permite a Interação com a Linha de Comando (```Terminal```)

- SHA1: É um conjunto de criptografia que atuam em arquivos a partir de um cunjunto de funções **hash**
  - Por meio dele, é feito a identificação do arquivo em uma sequencia de 40 caracteres
    - Caso Algo no arquivo mude, essa identificação tambem muda
    - Com isso, é possivel controlar e visualizar quando ocorrer a alreação em um arquivo

### Objetos Internos/Sistema Distribuido GIT

- Blobs: são objetos que contem metadados e informações de um objeto (arquivo)
  - Com a junção das Informações, no final é gerado um SHA1 da Blob encriptografando:
    - O Tamanho do Objeto
    - O caracter "\0" + O Conteudo do Objeto


- Tree: Armazena os Blobs
  - É reponsavel por apontar para os blobs (ou outras tree) dentro de um diretorio especifico
  - Com a junção das Informações, no final é gerado um SHA1 da Tree encriptografando:
    - Tamanho da Tree (Conteudo da Tree)
    - O caracter "\0"
    - Conteudo do Blob no seguinte formato:
      - "blob" + Titulo do Blob + Nome do Arquivo
  - Ex:
  ```
  - \Directory           - Tree (Ligada à duas Blobs e uma Tree)
  |- FileOne.txt         |- Blob
  |- FileTwo.txt         |- Blob
  |- \DirectoryImages    |- Tree (Sendo apontada por outra tree e Ligada à uma Blob)
   |- Image01.jpg         |- Blob
  ```


- Commit: Junta todo o conteudo Alterado e Encapsula em um Objeto Final
  - É um Objeto **unico**
  - O SHA1 do Commit é o HASH que representa toda a informação daqueles arquivos
  - Com a junção das Informações, no final é gerado um SHA1 do Commit encriptografando:
    - Aponta para uma Arvore
    - Aponta para um Parente
    - Aponta para um Autor
    - Possui uma Mensagem
    - Timestamp: leva o Horario/Data do momento em que ele foi criado


- O GIT leva uma logica de alteração em cascata, ja que
  - Um arquivo é alterado
    - O SAH1 do Blob é Alterado
      - O SHA1 da Tree é alterada
        - O SHA1 do Commit é alterado
- Como isso, o codigo possui a garantia que aquela é sua ultima alteração
- O GIT é um Sistema Distribuido: O codigo é hosteado em um Armazenamento em Nuvem (Repositorio Online) que representa a versão final de um projeto

### Estados do Git

- Tracked: O arquivo está sendo observado, ou seja, as alterações serão percebidas
- Untracked: O arquivo não está sendo observado, ou seja, as alterações não serão percebidas
- Estado dos Arquivos
  - Untracked: O GIT não conhece/observa o arquivo
    - Ao dar um ``git add name_file.txt`` o arquivo se torna conhecido pelo Git e virá um **Staged**
  - Unmodified (Tracked)
    - O Git já conhece o arquivo, mas ele não sofreu alterações
    - Caso o arquivo seja excluido, ele volta ao Untracked
  - Modified (Tracked): Arquivo que sofreu uma modificação
    - Quando um arquivo estava **Unmodified** e houve uma alteração
    - O Git percebe essa alteração pelo SHA1
    - Ao dar um ``git add name_file.txt`` o arquivo se torna conhecido pelo Git e virá um **Staged**
  - Staged (Tracked): Arquivos que estão "preparados" para virarem um **commit**
    - Ao concluir um **commit**, os arquivos retornam ao **Unmodified**

### Comandos

- ``git init``: Inicializa um Repositorio GIT no diretorio
  - Ao Iniciar um Repositorio, o diretorio ficará dividido em:
    - Working Directory: Onde estão os Arquivos
    - Staging Area: Onde estão os arquivos modificados e prontos (atraves do ``git add files.txt``) para virarem um commit
    - Local Repository: Local em que os commits após serem finalizados são armazenados
- ``git config --list``: Lista as Configurações do Git da Maquina
- ``git config --global --list``: Lista as Propriedades Definidas no Sistema
- ``git config --global name.of.proprities "value"``: Define o Item (``name.of.proprities``) com o valor informado
- ``git config --global --unset [propriete]``: Apaga os dados do Item (``propriete``)
- ``git config --global core.editor "code --wait"``: Define o Editor Padrão como o Visual Code e Coloca a Flag ``wait`` para ele aguaradar a edição ser concluida
- ``git remote add origin url_of_repository_github``: Linka o Local Repository com o Repositorio do GitHub (Server/Repositorio Online), dando o nome de ``origin``
- ``git push origin your_branch``: Envia os Commits do Repositorio Local para o Repositorio Online
- ``git clone url_project`` ou ``git@github.com:userOfRepository/nameRepository.git`` (Via SSH): Realiza um clone/copia do Repositorio do GitHub (Online)
- ``git remote -v``: Mostra os Links do Repositorio Local com o Repositorio Online (GitLab, GitHub)

### Conflitos de Arquivos

- Como Ocorrem ?
  - Ocorre quando duas pessoas estão alterando um mesmo arquivo, e as alterações coincidem no mesmo lugar e uma delas já disponibilizou seu arquivo no GitHub
  - Quando a segunda pessoa tenta executar um ``push`` nesse arquivo que coincidiu as alteraç~es, o GitHub irá rejeitar o arquivo e solicitar que faça um ``pull`` para sincronizar as alterações
- Como Resolver ?
  - ``git pull origin your_branch``: Obtem as Mudanças do GitHub (Repositorio Online)
  - Caso o Auto-Merge não seja Bem-Sucedido, abrir o arquivo que possui o Conflito e Mudar manualmente o conteudo que será mantido
    - ``git add file_mergerd.txt``
    - ``git commit -m "Mensagem Explicando Resolução do Arquivo"``
    - ``git push origin your_branch``

- Merge: GitHub realiza esse procedimento quando possuem alterações que coincidem no mesmo local
  - Nesse Processo, realiza uma sincronização das alterações que não coincidem, porem, é necessario que escolha de forma manual quais das alaterações que coincidiram serão mantidas



[<--- Pagina Anterior **(Repositorio do Curso Git/GitHub)**](README.md)

[Proxima Pagina **(02 - Protocolos de Autenticação e Segurança no Git/GitHub)** --->](02_Autenticacao_Seguranca.md)
