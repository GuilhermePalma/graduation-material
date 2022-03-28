# Protocolos de Autenticação e Segurança no Git/GitHub


### Conteudo

- [Resumo](#resumo)
- [Chaves SSH](#chaves-ssh)
  - [Explicação](#explicação)
  - [Utilização](#utilização)
- [Token de Acesso Pessoal](#token-de-acesso-pessoal)
  - [Explicação](#explicação-1)
  - [Utilização](#utilização-1)

---

## Resumo

Para relacionar um Repositorio Local com um Repositorio Online (Nesse caso, o GitHub), é necessario que realize a Autenticação. Por meio dela, o Usuario da Dispositivo Local consegue ter acesso e realizar modificações no Repositorio Online atraves sua Dispositivo. Para essa Autenticação no Git, é necessario realizar o Login utilizando o Email e Senha do GitHub, ou tambem utilizar uma Chave SSH ou um Token Pessoal.

A chave SSH utiliza de 2 Chaves, a Publica (para o GitHub) e a Privada (para o Computador Local). Por meio delas permite que estabeleça uma conexão segura entre o Computador Local com o Repositorio Online, não precisando realizar o Login pelo E-mail e Senha. *Passo a Passo pode ser [Encontrado Aqui](#chaves-ssh)*

Outra forma de acesso é por meio do Token de Acesso Pessoal. Ele é um codigo gerado no Proprio GitHub, em que é possivel delimitar quais permissões e acessos ele terá e a sua validade. É inserido na mesma etapa de Autenticação do Email e Senha, so que no campo ``Personal Token`` ou ``Token-ID``.  *Passo a Passo pode ser [Encontrado Aqui](#token-de-acesso-pessoal)*

---

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


[<--- Pagina Anterior **(01 - Estrturua e Introdução ao Git e GitHub)**](01_Estrutura_git.md)

[Proxima Pagina **(03 - Trabalhando com Branchs)** --->](03_Branches.md)
