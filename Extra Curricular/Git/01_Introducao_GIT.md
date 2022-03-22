# Introduçaõ ao Git

## Conteudo

> Aguardando Conclusã do Curso

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
