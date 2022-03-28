# Capitulo 1: Introdução à Internet e Infraestrutura

## Conteudo

- [Resumo](#resumo)
  - [O que é Internet](#o-que-é-internet)
  - [Dado](#dado)
  - [Bit](#bit)
    - [O que é Bit?](#o-que-é-bit)
    - [Movimentação](#movimentação)
    - [Velocidade de Transmissão](#velocidade-de-transmissão)
  - [Cliente e Servidores](#cliente-e-servidores)
  - [Infraestrutura](#infraestrutura)
    - [Tipologia: Peer-to-peer (Ponto a Ponto)](#tipologia-peer-to-peer-ponto-a-ponto)
    - [Comando ping](#comando-ping)
    - [Comando Traceroute](#comando-traceroute)

---

## Resumo

A palavra "Internet" se refere ao conjunto de redes inter-conectadas de dispositivos que permitem trocas de infromações entre si.

As Redes podem ser de diferentes tipos, tamanhos e estrutura. Nessas redes, são econtrados alguns tipos de aparelhos, como os Dispositivos Fianis - são os dispostivos de origem/destino, tambem chamados de hosts -, Dispositivos Intermediarios - aparelhos que na maioria fazem o controle de serviços, processos e dispositivos na rede - e as Midias de Rede - são os tipos e modos de conexão com a Internet.

Nas redes são trafegados os dados no formato de bits. Esses bits assumem o valor de 0 ou 1 e permitem que as informações reais, como texto, imagens e outros, sejam transmitidos pelos dispositivos. Esse trafego pode ocorrer por meio de impulsos eletricos, impulsos de luz ou
por meio de ondas eletronicas.

Já em relação à velocidade maxima de que um dispositivo pode transeferir dados para outro, é determinada conforme a Largura da Banda contratada. Enquanto a Velocidade Real que essa
transmissão ocorre, é chamada de produtividade.

A velocidade da Transmissão é determinada conforme a Largura da Banda. Conforme a interconexão das redes de internet, a velocidade sempre será maior que a menor largura de banda da comunicação.

Algumas medidads dessa velocidade de comunicação, são: Latencia, que se refere ao tempo que leva a comunicação de um ponto à outro e inclui os atrasos na comunicação, e Taxa de Transferencia ou Throughput, que diz respeito à taxa de transferencia de dados disponibilizados.

A estrutura da rede é dividida entre Clientes e Servidores, em que os servidores possuem softwares que disponibilizam um determinado serviço para que os Clientes (com os softwares necessarios) possam realizar solicitações e receber o conteudo desse serviço.

Alguns comando permitem com que faça a medição do tempo entre essas comunicações dentro da rede. Como por exemploo, o comando 'ping', que diz o tempo que leva uma comunicação entre dois dispostivos da mesma rede. Enquanto o comando Traceroute, faz o mapeamento dos dispositivos e o tempo que a solicitação passou por eles.

Por fim, a tipologia Peer-to-peer, se trata de uma rede mais simples possivel, em que é realizada a conexão entre dois computadores, permitindo com que eles troquem serviços e dados. É uma tipologia simples, porem não é possivel ser aplicado quando se tem muitos dispositivos. Tambem pode ocorrer um baixo desempenho por conta dos computadores desempenhar funções tanto de clientes como servidores e não é nada segura.

---

### O que é Internet

- A Internet não é posse de nenhuma pessoa, e sim um conjeitno mundial de redes intreconectadas
  - Essas redes trocam informações atraves de padrões comuns entre si. Seja eles fios de telefones, cabo de fibra otica, links de satelite, transmissões sem fio, etc
  - Tudo que é acessado está em algum lugar na Internet Gloval
- Tipos de Redes
  - Domestica: Pequeno porte que conecta alguns computadores
  - Pequenas de Escritorio/Residencias: Rede pequena ou SOHO (Small Office Home Office) que permite que permite que computadores em um escritorio domestico ou remoto se conecta à rede coorporativa
  - Media a Grande: Usadas em coorporações e escolas e posssui um grande numero de computadores conectados
  - Rede Mundial: A Rede responsavel por interligar milhares de computadores
- A conexão dessa rede permite com que os computadores acesse recursos compartilhados, como Documentos, Impressoras e outros
- Nas grandes redes, é possivel vender produtos, ter uma comunicação facilitada com os clientes (por meio de emails) e acessar informações armazenadas em servidores na rede
- Redes SOHO e empresariais permitem uma conexão compartilhada da internet, sendo formada a partir de milhares de redes interconectadas entre si

### Dado

- São valores que representa algo (Numeros, Caracteres, Textos, etc)
- Dado Voluntario: Dados que a Pessoa escolhe criar/compartilhar
- Dado Observado: Dados obtidos atraves do registro de atividades de um Usuario
- Dado Inferido: Dados que são obtidos atraves de analises de dados (dados fornecidos ou observaos)

### Bit

#### O que é Bit?

- Podem assumir apenas dois valores: 0 ou 1
- É uma abreviação de "Digito Binário"
- Dentro do computador, tudo é interpretado, armazenado e processado em Bit
- Os dispositivos de entrada (mouse, teclado e outros) convetem as interações humanasem codigo binario para ser processado pelo computador
- Cada Letra/Numero/Caracter é transformado em Bits, tendo diferenciação entre caracteres maiusculos e minusculos
- Byte: Uma combinação de uma serie de oito Bits

#### Movimentação

- Após ter os dados transformados em Bit, eles são transmitidos para o seu destino. Essa transmissão pode ser realizada por:
  - Sinais Eletricos: Transmissões por meio de pulsos eletricos em fios e cabos
    - Fios de Cobre
    - Cabo de Fibra Optica
  - Sinais Opticos: Conversões de Sinais Eletricos e Pulsos de Luz
  - Sinais sem Fio: Transmissão de dados por meio de Ondas, podendo utilizar das ondas infravermelhas, micro-ondas ou ondas de rádio

#### Velocidade de Transmissão
- A quantidade de bits transmitidos pode variar conforme a lagura da banda disponivel
para transportar dados.
- A valocidade de transmissão inicia em bit/segundo e avança até Tb/s (Trilhoes de bits por segundos)
- As medidas de rendimento de rede não avaliam a validade da infirmação transmitida, dessa forma, não considera os possiveis erros ocorridos na transmissão da rede
- Em uma inter-redes, o rendimento não pode ser mais alto do que o link mais lento no percurso
  - Basta um pequeno segmento com a largura de banda mais lento para que haja lentidão na transmissão da rede
- Latencia: Se refere ao tempo necessario para a transmssão de dados de um ponto à outro incluindo atrasos
  - A latencia pode variar conforme o Tipo de Dados Transmitido e a quantidade de dispositivos conectados a rede que se encontra entre a origem e destino
- Taxa de Transferencia (Throughput): Medição da taxa dos dados disponibilizados atraves da rede do dispositivod e origem para o de destino
- Largura da Banda: Medição da Velocidade **Teorica** dos dados transmitidos na rede
  - Itens que determinam a Largura de Banda DisponiveL: Propriedades Fisicas da Midia, Tecnologias Disponiveis e Leis da Fisica
  - Itens que determinam a sua Produtividade: Quantidade de Dados Trasnmitidos/Recebidos, Tipo de Dados, Latencia criada pelos dispositivos presentes na Rede

### Cliente e Servidores

- Todos os aparelhos que conectados à uma rede e que participam diretamente na comunicação, são chamados de hosts
- Um host pode atuar como servidor, cliente ou ambos
  - Conforme o Software instalado, determina a função daquele dispositivo
- Servidores possuem softwares que permitem fornecer informações
  - Tudo que acessamos, é fornecdio por um servidor localizado em alguma parte da internet global
- Clientes são os dispositivos que realize solicitaões de informações do servidor
- Resumidamente, o Servidor armazena e disponibiliza as informações, enquanto os Clientes solicitam e acessam essas informações
- Tipos de Clientes/Servidores
  - Cliente/Servidor de Arquivos
  - Cliente/Servidor Web
  - Cliente/Servidor de Emails
- Tanto os Servidores como Clientes, podem ter um ou mais softwares instalados para que disponibilizem ou solicite os serviços
  - > Ex: Um Cliente pode apenas ter um Software para acessar emails, e outro pode ter o de acesso à emails, arquivos e navegar na web


### Infraestrutura

- Durante a comunicação entre os Dispositivos, possuem diversos Dispositivos, divididos em 3 Tipos:
  - Dispositivos Intermediarios
    - Roteador e Roteador sem Fio
    - Switch e Switch de Provedor de Serviços
    - Access Point Sem fio
    - Fireall
    - Gerenciador de Chamadas
  - Dispositivos Finais (Hosts): São a Origem e/ou destino de uma Mensagem transmitida pela Rede
    - Laptop
    - Impressora
    - Tablet
    - SmartPhone
    - Telefone IP
    - Desktop
    - Servidor
  - Midias de Rede
    - Midia LAN
    - Midia WAN
    - Midia Sem Fio
    - Nuvem

#### Tipologia: Peer-to-peer (Ponto a Ponto)

- É uma rede simples que interliga dois computadores por meio de uma conexão com ou sem fio
  - Ambos os Computadores trocam Dados e serviços entre si
  - Atuam como CLiente ou Servidor conforme necessario
- Para criar uma rede peer-to-peer maior, é necessario um Switch para interligar os computadores
- Vantagens: Simples de configurar, custo baixo e pode ser usada em tarefas simples
- Desvantagens
  - Não é centralizada, segura ou escalavel
  - Todos os dispositivos podem atuar como servidores e clientes, diminuindo o desempenho das conexões

#### Comando ping

- É um comando para identificar a conectividade entre dois pontos de uma mesma rede
- É feita uma medição do tempo que leva a transmissão entre a origem e destino
- Caso ocorra um erro, não é mostrada nesse comando
- Sinteaxe: ```ping ip_destino```

#### Comando Traceroute

- Como a Internet é formada por milhares de redes interligadas, para realizar uma comunicação entre o destino e origem, existe diversos servidores nesse processo
- Cada rede individual que uma mensagem trafega é chamada de **salto**
- Esse comando realiza um mapeamento de todos os "saltos" entre o destino e origim da comunicação

---

[<--- Pagina Anterior **(Pagina Inicial)**](README.MD)

[Proxima Pagina **(Capitulo 2 - Redes no Dia a Dia)** --->](02-Redes_no_dia_dia.md)