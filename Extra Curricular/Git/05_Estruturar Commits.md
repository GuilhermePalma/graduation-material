# Estruturando Bons Commits

### Estrturando Commits

- Por que ?
  - Melhor Leitura do Historico de Commits
  - Ser Amigavel aos outros desenvolvedores
  - Ser Amigavel ao Versionamento Semantico
- Commit Atômicos
  - Commits devem ter Incio, Meio e Fim em um Commit
  - Agrupar os Commits entre si e evitar ficar fazendo pequenos commits especificos
- Portugues ou Ingles
  - Depende do cenário
  - Caso sejam projetos focados em pequenos projetos/empresas brasileiras, manter em portugues. Entretanto, caso seja um projeto focado em uma abrangencia maior, é ideal usar o Ingles
- Formação do Commit
  - Assunto: Mensagem de Titulo do Commit
    - Curto e Compreensivel (Até 50 Caracteres)
    - Iniciar com Letra Maiuscula e não utilizar ponto final
    - Escrita de Forma Imperativa
      - Seria como se estivesse dando uma ordem
      - Usar Verbos no Presente (Ações que acontecem AGORA e não no passado)
        - Ex: ``Adiciona a Funcionalidade XXYYYY``
      - Para Facilitar a mensagem, pensar na Frase: ``Se Aceito, esse commit [mudanças que serão implementadas]`` e usar a Frase entre Parenteses
        -  Ex: ``Se Aceito, esse commit [Remove Codigo Redundante]`` -> Mensagem do Commit: ``Remove Codigo Redundante``
  - Corpo: Descreve os Detalhes/Observações do Commit
    - Adicionar Detalhes da Implementação/Atualizações daquele commit
    - Quebrar Linhas em 75 Caracteres
    - Explicar Tudo do Commit
      - Pensar que a pessoa que está lendo não sabe o que está no codigo ou o que foi feito nele 
    - Utilizar Markdown
  - Rodapé: Referenciar Assuntos/Issues/Commits Relacionados

### Pratica: Estruturando Commit

- ``git commit -m "Alguma Mensagem"``: Permite que o Usuario crie um Commit inserindo o ``Assunto`` (Titulo) do Commit direto
- ``git commit``: Abre no Editor Padrão uma Interface para "Criar e Configurar" o Commit
  - ``Assunto``: Inserir na 1° Linha Inserir a Mensagem de Titulo do Commit
  - ``Corpo``: Inserir a partir da 3° Linha (Separar o ``Assunto`` do ``Corpo``)
    - Breve Descrição do Commit
    - Detalhar as Tecnologias/Recursos Utilizados naquele Commit
      - Ex: Iniciar com ``Esse commit faz uso de: [Lista em Markdown de Recursos Utilizados]``
  - ``Rodapé``: Pular uma Linha após o ``Corpo`` e Linkar por meio das Palavras Chaves a ``Issues`` ou o SHA1 do Commit


### Commits Semantico

#### Versionamento Semantico

- Especificação de Versionamento Semântico (SemVer)
- Major
  - É alterada quando acontece uma grande alteração que afeta a Compatibilidade da Versão
    - Mudanças em Nomes de Campos, Logicas e Regras de Negocios, Etc
- Minor
  - É alterada quando acontece uma alteração (grande/media), mas não há mudança na Compatibilidade na Versão
    - Alteração no Layout de um site, mas mantendo os campos iguais
- Patch
  - É alterada quando acontece pequenas alterações
    - Correção de Bugs

#### Conventional Commit/ Commits Semanticos

Seguir o Passo a Passo: [Conventional Commits](https://www.conventionalcommits.org/pt-br/)

- O Commit seria estruturado da seguinte forma: 
```bash
## No Editor Padrão, formatar o Commit:
[Tipo]: [Mensagem de Titulo do Commit] 

[Corpo/Descrição do Commit (Opcional)]

[Footer (Opcional)]
``` 

- É uma convenção simples de como utilizar mensagens de Commits
- Possui um conjunto de regras para criar um historico explicito de commmit
- Utiliza das Especificações do **SemVer**

- O ``Assunto`` (Mesnagem de Titulo do Commit) pode iniciar de algumas Formas:
  - ``fix``: Significa que o Commit estará resolvendo um Problema e com isso, o Numero da ``PATCH`` será acrescido
  - ``feat``: Abreviação de ``Feature``. Significa que o Commit está incluindo uim novo recurso na Base de Codigo. Com isso, o ``MINOR`` será acrescido
  - ``fix`` ou ``feat`` + ``!``: Significa que houve uma quebra na Compatibilidade na Base de Codigo. Com isso, o ``MAJOR`` será acrescido
  - > Além do ``fix`` e ``feat``, existe outros **Tipos** de Commits. Por Exemplo: "build", "chore", "ci", "docs", "style", "refactor", "perf", "test", etc

