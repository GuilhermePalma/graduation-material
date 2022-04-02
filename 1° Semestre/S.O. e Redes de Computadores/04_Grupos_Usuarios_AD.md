# Usuarios em Massa

## Conteudo

- [Conteudo](#conteudo)
  - [Resumo](#resumo)
  - [Unidades Organizacionais (OU)](#unidades-organizacionais-ou)
  - [Criação de Contas de Usarios](#criação-de-contas-de-usarios)
  - [Propriedadas do Usuario](#propriedadas-do-usuario)
  - [Adicionando Usuarios em Massa](#adicionando-usuarios-em-massa)

### Resumo

> Agurade...

### Unidades Organizacionais (OU)

- ``Unidades Organizacionais/OU`` são responsaveis por gerenciar o nivel de acesso dos usuarios da rede (Nivel Hierarquivo de Acessp)
- São grupos no Active Directory usados para atribvuir poermissões de acesso dentro de uma Empresa

> Logon: Processo de Login do Usuario na Rede
> - Carrega os Dados do Usuario na Rede e Sincroniza todas as Propriedades Necessrias

### Criação de Contas de Usarios 

- Precisam dos atrivutos:
  - ``CN``: Seria o Nome Identificador do Usuario
    - Formação Normalmente Usada: ``Primeira letra do nome`` +  ``.`` + ``Ultimo Sobrenome``
    - Caso acotneceça de ter pessoas com o ``CN`` iguais é adicionado um gnumero no final
  - Logon UPN: Prefixo de Nome de acesso do Usuario + ``@`` + logon UPN (Normalmente o Dominio da Rede)

### Propriedadas do Usuario

- Criando um Usuario
  - Abrir o ``Acess Directory`` -> Botão Esquerdo no Dominio -> ``Gerenciar``
  - Botão Esquerdo no Dominio -> ``Novo`` -> ``Unidade Organizacional``: Criar uma Unidade Organizacional (``Temp`` p/ ma unidade de Testes)
  - Selecionar a Nova ``Unidade Organizacional``
    - Botão Esquerdo no Dominio (``Temp``) -> Criar um ``Usuario`` e um ``Grupo``

- Configurando o Usuario:
  - Clicar 2x no Usuario
  - Abas ``Geral`` e ``Endereço`` configuram os Dados Gerais e de Endereços de E-mails 
  - Aba ``Conta``
    - ``Nome de Logon``: Configura o Login do Usuario na Rede
    - ``Horario de Logon``: Define o Horario permitido que o Usuario se conectará na Rede
      - Após esse horario, o Usuario não consegue realizar o Logon novamente. Entretanto, caso o Computador não realiza o Processo de ``Logoff``, o Usuario continua conectado no Computador
      - Caso ele tente realizar o Logon fora do Horario, não será permitido
    - ``Fazer Logon em``: Define uma maquina especifica para realizar o Logon 
      - Caso não seja essa maquina, não é permitido p Logon
    - ``Desbloquear Conta``: Nessa Propriedade é possivel Bloquear e Desbloquear um Usuaroi
    - ``Vencimento da Conta``: Define um Prazo para o Usuario
      - Mais Utilzado para quando há dispositivos externos (Fora da Rede) acessando a rede
  - Aba ``Perfil``
  -  ``Caminho de Perfil``: Define um Local que armazenará as Informações (Diretorios, Arquivos, Dados) do Usuario
      - Permite que carregue essa informações em outros computadores da rede
      - ``Script de Logon``: Define um Script Executavel que irá ser carregado após o Logon
      - ``Pasta Base`` --> ``Conectar``: Define o caminho que armazena os dados/documentos do Usuarios
 - Configurando Grupo
  
### Adicionando Usuarios em Massa

- Comando para adicionar um Usuario por Script:
  - Executar o Comando: ``dsadd <<tipo_de_objeto>> <<campo>>=<<atributo>>,<<campo2>>=<<atributo2>>``
    - Outra Forma: ``dsadd <<-tipo_de_objeto>> <-campo>>=<<atributo>> <<-campo2>>=<<atributo2>>``
      - Nessa Forma, não necessario adicionar as virgulas, apenas os Hífens (-) demonstram que começou outro campo
    - Tipo do objeto : computer, contact, gtroup, ou, user , quot
    - (Caso os campos sejam separados com as virgulas) Não dar espaço após o atributo
    - Nescessita das Aspas: Caracteres Especiais, Espaços em Branco
    - Caso acesse um Dominio dentro de Outro dominio, é necessario adicionar novos dc
      - Ex: Dominio: fatec.local.osasco --> ``dsadd user cn="u.userName",ou=something,dc=fatec,dc=focal,dc=osasco ...``
