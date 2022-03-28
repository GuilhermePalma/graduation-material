# Capitulo 2: Redes no Dia a Dia

## Conteudo

- [Resumo](#resumo)
  - [Dispositivos Moveis](#dispositivos-moveis)
  - [Conectividade](#conectividade)
  - [IP, Mascara e Gateway](#ip-mascara-e-gateway)
  - [Representações da Rede](#representações-da-rede)
  - [As Midias de Rede](#as-midias-de-rede)
    - [Par Trançado](#par-trançado)
    - [Comunicação Usando os Cabos UTP](#comunicação-usando-os-cabos-utp)
    - [Cabo Coaxial](#cabo-coaxial)
    - [Fibra Optica](#fibra-optica)

---

## Resumo

Hoje em dia há diferentes recursos que podem ser utilizados para se manter conectado com o mundo.
- Utilização das ondas de radio, tanto para comunicações por mensagens e ligações, como por Wi-Fi
- Transmissões de sinais via satelite (GPS) para localização
- Criação de pequenas redes e trocas de dados, utilizando o Blootooth
- Utilização de NFC para Pagamentos via celular

Com isso, exite uma divisão entre os aparelhos que trocam os dados (Hosts), os dispositivos que controlam e movimentam esse trafego (Dispositivos de Rede/Intermediarios) e os meios que essa comunicação ocorre (Midia de Rede).

Para que essa comunicação ocorra de forma controlada, é utilizada a placa de Ethernet NIC que cada uma possui um endereço unico, chamado de MAC. Além disso, possuem alguns recursos para essa comunicação
- Endereço de IP para a identificação do computador na rede
- Mascara de Sub-Rede que identifica em que rede o Dispositivo está
- Gateway Padrão que identifica o dispositivo que o Host utiliza para sua conexão

Alem disso, é necessario alguns serviços e processos que permitam com que essa comunicação ocorra. Um dele é o servidor DNS, que realiza a conversão de dominios/urls em endereços de IP. Outro é o servidor DHCP, utilizado para gerar um pool de endereços para as solicitações.

Para manter toda a rede bem organizada, é necessario um planejamento. Nesse planejamento é utilizado o Diagrama de Topologia Fisico, que é descrito a parte da arquitetura e como essa rede será estruturada, mas deixando de lado as configurações e especificidades dos dispositivos. Enquanto o Diagrama de Topologia Logica, é responsavel pela descrição das especificidades dos dispositivos, como o range de IP, Mascara de Sub-Rede, Softwares de Transmissões e Solicitações de recursos

Para realizar a comunicação dos aparelhos entre si, é utilizado as Midias de Rede. Elas são dividias em alguns tipos:
- Par Trançado: Cabo que permite a comunicação entre os dispositivos. Ele é um cabo trançado, em que seus fios possuem cores e um determinado padrão para formar as pontas para que a placa Ethernet consiga enviar e receber as solcitações. Esse cabo é sucetivel à interferencias eletricas, por isso, exite uma versão blindada do cabo. Alem disso, a manipulação é mais simples, porem tem algumas limitações em relação à qualidade das transmissões e transferencias.
- Cabo Coaxial: Esse cabo é utilizado por Operadoras de TV/Internet e Comunicações via satelite. Ele garante comunicações de alta frequencia, transmitindo dados por pulsos eletricos, contendo uma camada de blindagem, e um adpatador em sua ponta para a conexão.
- Fibra Optica: É um cabo que realiza as transmissões por pulso de luz, tendo uma maior resistibilidade à ações do ambiente e não sofrendo interferencias eletricas. É utilizados para conexões de alta velocidade e para longas distancias.

Por fim, para escolher a Midia de Rede recomendada à cada cenário, é necessario avaliar: a distancia em que a transmissão irá ocorrer, o ambiente que será instalado, a quantidade de dados e velocidade necessaria para a transmissão, o custo e o modo de intalação dessa midia.

---

### Dispositivos Moveis

- Os celulares usam ondas de radios par transmitir sinais de voz a antenas que abragem uma regiao especifica
- Ao realizar uma ligação, o sinal de voz é retransmitido de uma torre à outra até chegar no destino
  - Essa mesma logica pe valida para as Mensagens enviadas pelos Telefones
- Com o paassar do tempo, as redes de transmissões foram evoluindo. Gerando assim o 2G, 3G, 4G, etc
  - O "G" significa "Geração", ou seja, conforme evolui, incrementa a geração do numero
- GPS: Ele utiliza satelites para transmitir sinais e calcular o telefone em uma precisão de 10 metros
- Wi-Fi: São transmissores e receptores desinais que permite a conexão de redes locais com a Internet.
  - Normalmente são redes particulares, mas existem Hotspot publicos em que o WiFi é disponivel
- Bluetooth: Tecnologia que funciona em uma distancia pequena que substitui as conexões por fio.
  - Normalmente são usadas para criar pequenas redes locais
- NFC: Significa "Comunicação a curta distancia". Ela permite a troca de dados entre dispositivos bem proximos (Normalmente, são centimetros de proximidade)


### Conectividade

- Hosts: Dispositivos que trocam informações entre si, enviando e recebendo mensagens
  - Possuem softwares que permitem a utilização dos perifericos conectados
- Perifericos: São dispositivos que não comunicam-se entre si, dessa forma, dependem de um hosts para realizar as operações na rede
  - Cameras, Impressoras, Scanners, etc
- Dispositivos de Rede/Dispositivos Intermediarios: São responsaveis por conectar os dispositivos da rede.
  - Eles controlam e movimento o trefego da rede
  - Intermediarios pois estão entre o host de origem e destino
  - Hubs, Switches, Roteadores
- Midia de Rede: São os cabo, fios e as ondas de radio frequencia utilizados para serem caminhos para as comunicações acontecerem entre os componentes da rede
- Pode ocorrer dos dispositovos desempenhar mais de uma função
  - Ex: Conectar uma impressora conectada à um dispositivo de rede
- Os dipositivos usam uma Ethernet NIC (Network Interface Card) para acessar a LAN (Local Area Network) de Ehernet
  - Cada um possui o endereço MAC (Controle de acesso à midia), que se trata de um endereço unico permanente na placa.
  - Permite a conexão com ou sem fio à midia de rede
  - Para ocorrer a comunicação, é necessario um Endereço de IP

### IP, Mascara e Gateway

- Endereço de IP (Internet Protocol): Idnetifica um Computador na Rede
- Mascara de Sub-Rede: Idenfica a Rede que o Host está conectado
- Gateway Padrão: Identifica o dispositivo utilizado pelo host para acessar a Internet ou rede remota
- Servidor DNS: Faz a conversão de Dominios (ex: www.google.com.br) em endereços de IP
- O Endereço de IP pode ser atribuito de duas Formas:
  - Manual
    - Resulta em um IP Estatico que é inserido pelo administrador da rede
    - Se torna um endereço permanente do dispositivo
  - IP Dinamico
    - As solicitações são realizadas a partir de um pool de endereços atribuidos por um Servidor DHCP (Dynamic Host Configuration Protocol)


### Representações da Rede

- Diagramas de Topologia Fisico
  - Utilizadas para descrever a oranização e arquitetura da rede em si
  - Utilizam de Simbolos/Icones para representar os dispositivos e conexões
  - Uteis para incluir novos dispositivos e detectar problemas nas conexões
  - Contem dados que não alteram com o tempo
    - Contabiliza de forma Generica os dispositivos finais/hosts
    - Foca na descrição da arquitetura da rede em si, visando os dispositivos intermediarios e as midias da rede
    - Não possui dados que podem alterar com o tempo
      - Ex: Endereço de IPs. Ao adicionar um novo computador, é adicionado um novo IP
- Diagrama de Topologia Logica
  - Representa as Informações importantes de configuração da Rede, como IPs, Mascaras de Rede e Gateay, Softwares nos Servidores e Computadores

### As Midias de Rede

- São as Linhas ou Transmissões sem fio que conectam os dispositivos
- Autalmente, são divididas em 3 Tipos:
  - Fios de cobre (ex: Cabo de Rede)
  - Fibras Plasticas ou de Vibro (ex: Fibra Optica)
  - Transmissões sem Fio (ex: roteadires)
- Os fatores que afetam a escolha do tipo de Midia são:
  - Até qual Distancia em que o sinal sera transmitido terá exito
  - Ambiente em que será instalado
  - Quantidade de Dados e Velocidade da Transmissão
  - Custo e Instalação da Midia

#### Par Trançado

- Utilizado na Ethernet
- Utiliza cabos de cobre em pares trançados para reduzir a interferencia
  - Realizam as comunicações por pulsos eletricos
- Os cabos possuem cores, normalmente um com a cor solida e outro mesclado com branco
- Cabo mais barato em comparação com os demais
- Esse cabo é sensivel à interferencias eletroagneticas, que acaba reduzindo seu rendimento
  - Deve ficar afastado de aparelhos que emitam essa interferencia, como micro-ondas, acessorios de luz fluorescente e cabos de energia
- Estão sujeitos à diafonia (Crosstalk)
  - Quando cabos são agrupados para grandes distancias e o impulso eletrico pode acbar se mudando para o cabo ao lado
  - Normalmente ocorre quando a instalação não foi bem feita
  - Perde qualidade pois é necessario retransmitir os dados
- Cabo UTP: Par Trançado não Blindado
  - Se trata dos Cabos de Par Trançado que não pussui blindagem ou proteção contra interferencias
  - Sofre interferencia eletromagnetica
  - Deve ser utilizado longe de dispositivos que emitam ondas eletromagneticas ou cabos que transmitam energia
- Cabo STP: Par Trançado Blindado
  - Possuem uma camada extra de blindagem
  - Recomendado para serem utilizados em fabricas ou locais que não há outra opção a não ser passar junto com coisas que podem gerar interferncias
  - Mais dificil de manipular, menos flexivel
  - Possuem requisitos adicionais para seu funcionamento
- tipos de Cabo
  - UTP Cat 3: 10 Mb/s - 16 MHz. Usado nas Linhas Telefonicas e LAN Ethernet (Redes Locais Pequenas)
  - UTP Cat 5: 100 Mb/s - 100MHz. Padrão superior ao Cat 3, com maior taxa de transferencia de Dados
  - Cat 5e UTP: 1000 Mb/s - 100MHz. Superior ao Cat5, com maior taxa de transferencia e é mais trançado, previnindo interferencias
  - UTP Cat 6: 1000 Mb/s - 250. Superior ao Cat5e, com maior taxa de transferencia e é mais trançado, previnindo interferencias
  - Cat 6a UTP: 1000 Mb/s - 500MHz. Superior ao Cat6 e utilizados em grandes volumes de dados (Video Conferencia e Jogos), possui um divisor de plastico entre os pares, previnindo interferencias.
  - Car 7 ScTP: 10 Gb/s - 600MHz. Mais caro, não possui a mesma flexibilidade que o UTP
- Os cabos de Par Trançado, possui 2 padrões (T568A e T568B) na sequencia de monta-los
  - Os Padrões se alteram apenas na posição 3 e 6
  - É imporante manter um mesmo padrão durante as conexões

#### Comunicação Usando os Cabos UTP

- A comunicação entre as pontas do cabo de par trançado são realizadas atraves das Entehernet NIC em que cada pinos possui sua função.
  - Ex: Determinados pinos são usados para enviar solicitações e outros para receber a transmissão
- Quando os dois dispositivos do mesmo tipo estão diretamente conectados por um cabo cross-over (cabo cruzado, que possui as pontas em padrões diferentes)
  - Já em aparelhos diferentes, cada um possuirá pinos diferentes para a transmissão e recepção, podendo usar as pontas no mesmo padrão (cabo straight-through)


#### Cabo Coaxial

- Utilizado para Transmissões de Alta Frequencia (Banda Larga e alta Frequencia)
  - Utilizado pelas Empresas de TV para fornecer o serviço
  - Utilizado por alguns compionentes que se comunicam via satelite
- Normalmente, possui um cabo central cobre ou aluminio, envolto em uma proteção de plastico e em uma camada de metal trançado, dando mais rigidez, segurança e menos interferencia no cabo
- Transmite Dados por impulsos eletricos
- Possui um adaptador para a conexão da ponta do cabo com o dispositivo
- É fisicamente mais dificil de instalar do que o UTP

#### Fibra Optica

- Utilizados para uma grandes volumes de transmissão de dados em alta velocidade
  - Utilizados tambem em tratamentos medicos, imagens e inpeções
  - utilizados em grandes empresas e data centers
- Formação (Ordem da Camada Mais Externa para a mais Interna)
  - Capa: Formado de PVC, resistindo a condições ambientes, como umidade
  - Meterial de Reforço: Camada de Proteção, normalmente feito do amterial de coletas a prova de bala
  - Buffer: Camada de proteção do nucleo e do revestimento interno contra danos
  - Revestimento Interno: Normalmente, composto por produtos quimicos que reflita a luz devolta ao nucleo, mantendo ela sempre centralizada
  - Nucleo: Elemento de Vidro ou Silicio que transmite a luz
- Transmitem os dados por impulsos de luz (lasers ou leds), não conduzindo eletricidade e não sofrendo com interferencias eletricas
- São mais resistentes as condições de ambientes externos
- Os circuitos são montados de forma que tenha 2 cabos de Fibra Optica, um para envio e outro para recebimento de dados

---

[<--- Pagina Anterior **(Capitulo 1 - Introdução à Internet e Infraestrutura)**](01-Introducao_Internet.md)

[Proxima Pagina **(Capitulo 3: Introdução à Protocolos, Modelos, Comunicações na Rede e seus Dispositivos)** --->](03_Ethernet.md)
