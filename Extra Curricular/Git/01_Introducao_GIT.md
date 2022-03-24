# Introduçaõ ao Git

## Conteudo

> Aguardando Conclusão do Curso

---

## Resumo

O GIT é um software de versionamento de codigo, que permite que trabalhos sejam organizados e disponibilizado akterações em versõs.
Dessa forma, organiza e facilita o trabalho em grupo em um projeto.

GitHub permite que o codigo versionado do GIT seja amrazenado em nuvem.

> Aguardando Conclusão do Curso

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

### Chaves SSH

#### Explicação

- Chave SSH: Uma maneira de estabelecer uma conexão segura e criptografa entre 2 dispositivos (nesse caso, o GitHub e a maquina Local)
  - É utilizado 2 Chaves: Publica e Privada
- Voltado à utilização de comandos pelo Protocolo SSH
- Permite que seja realizada Operações no GitHub sem a autenticação via Email/Senha ou Token, utilizando apenas o Protocolo SSH
  - Ex: Após Registrar as Chaves SSH, é possivel clonar um Repositorio pelo Git Bash sem realizar a Autenticação.

#### Utilização

- Gerando e Cadastrando uma Chave SSH:
  - Abrir o Git Bash
  - Executar: `ssh-keygen -t ed25519 -C your_email@email.com`
  - Dar ``Enter`` ou Especificar uma Outra Pasta que salvará as Chaves
  - Digitar e Confirmar uma Senha
    - Irá Gerar 2 Chaves: A Publica (terminada em .pub) e a Privada
- Cadastrando a Chave SSH no GitHub:
  - Navegar até a Pasta das Chaves SSH
  - Obter a Chave Descriptografada executando: ``cat id_your_key_generated.pub``
  - Acessar o GitHub -> Clicar na Foto de Perfil -> ``Seetings`` -> ``SSH and GPG Keys`` -> ``New SSH Key``
  - Copiar e Colar o Resultado no Comando Campo ``Key`` do GitHub
  - Clicar em ``Add SSH Key``
- Linkando a Chave SSH Localmente:
  - Inciar o SHH Agent executando: ``eval $(ssh-agent -s)``
    - SHH Agent é responsavel por Lidar e Gerenciar as SSH Keys
  - Registrando a Chave no SHH Agent
    - Entrar na Pasta com as Chaves SSH
    - Registrar a Chave SSH Privada: ``ssh-add id_your_key_generated``
    - Entrar a Senha usada na Criação
  - Ao Utilizar à primeira vez, pode ocorrer um erro de não ter a chave registrada. Apenas digitar ``yes``

### Token de Acesso Pessoal

#### Explicação

- Se Trata de um Token, que possui uma data de expiração, removendo a autenticação via Email/Senha em metodos que utilizam o metodo HTTP
- Como é salvo localmente, não é muito recomendado para aparelhos compartilhados

#### Utilização

- Criando o Token:
  - Acessar o GitHub -> Clicar na Foto de Perfil -> ``Seetings`` -> ``Developer Settings`` -> ``Generated New Token``
  - Definir um **Titulo** ao Token
  - Definir o Prazo de Expiração -> ``Expiration``
  - Para utilizar as Funções Basicas do CLI (Terminal), marcar a Opção ``repo``
  - Verificar quais as outras funcionalidades que são necessarias
  - Na parte inferior, clique em ``Generation Token``
  - Copiar o Token (só é possivel visualizar o Token 1 vez)

- Ao Realizar alguma operação que demande a Autenticação (Ex: Clone de Repositorio), Informar no Campo Especifico o Token Criado

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
- ``git config --global name.of.proprities "value"``: Define o Item (``name.of.proprities``) com o valor informado
- ``git config --global --unset propriete``: Apaga os dados do Item (``name.of.proprities``) com o valor informado
- ``git remote add origin url_of_repository_github``: Linka o Local Repository com o Repositorio do GitHub (Server/Repositorio Online)
- ``git push origin your_branch``: Envia os Commits do Repositorio Local para o Repositorio Online
