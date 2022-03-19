# Capitulo 4: IPs e Transmissão na Rede

### Endereço Logico IPv4

- É atribuido a cada dispositivo pela interface de rede (NIC)
- É um endereço que localiza o Host na Rede
- É composto por uma serie de 32 bits binarios, agrupados em 8 Bits chamados de Octetos
  - Os octetos são represntados com valor decimal, separados por pontos ou virgulas
  - São possiveis mais de 4 Bilhos de combinações de endereços de IPv4 usando o endereçamento de 32 Bits
- Para Transformar os 8 Bits em octetos, é utilizado a seguinte logica
  - As casas da direita para a direita valem:1, 2, 4, 8, 16, 32, 64, 128
  - Bit com valor 0, significa que o numero nessa casa não é computado, caso seja 1, será utilizado o seu valor
    - Ex: 00000000 = 0
    - Ex: 00000101 = (4+1) = 5
  - Valor maximo do octeto é 255
- Os 3 primeiros octetos (XXX.XXX.XXX) reprensetam a rede e o ultimo (.YYY) se trata do numero unico do host na rede
  - Os Hosts com os mesmos nuemros conseguem se comunicar entre si, mas não consegeum acessar hosts de outras redes

### AND Logico

- É uma das tres operações binarias basicas
- Realiza a comparação de dois bits (segue a logica do tipo bool de variavel)
  - Apenas 1 and 1 resulta em 1, caso contrario, resulta em 0
- Processo utilizado para identificar  o endereço de rede por meio da comparaçãp do IPv4 e a mascara de sub-rede
  - A partir desse processo, é possivel determinar se os dispositivos es~tao na mesma rede. Caso esteja, o pacote será entregue localmente, se não, terá que ser encaminhado ao roteador local para realizar a comunicação
  - Ex: Endereço de IP (192.168.10.10), mascara de Sub-rede (255.255.255.0), fazendo o AND irá resultar na rede 192.168.10.0

### Mascara de Sub-Rede

- Responsavel por identifcar qual parte é o endereço de rede e qual parte é o do host
- A compração é feita dentro dos conjuntos de octetos
- Por meio dela é possivel determinar quantos endereços hosts poderão ter na rede
    - Na mascara de Sub-Rede, a parte do host sempre será 0

### Endereçamento Classful e Classless

- Antigamente, os IPv4 eram atribuidos à um endereçamento classful, onde os clientes eram separados em tres categorias:
  - Classe A:
    - 0.0.0.0/8 à 127.0.0.0/8
    - Redes Grandes, com 16 milhoes de endereços de host
    - Usa o primeiro octeto para endereço de rede e os tres ultimos para enderços host
  - Classe B:
    - 128.0.0.0/16 à 191.255.0.0/16
    - Comportam redes medias, com 65.000 endereços de rede
    - Usa o Prefixo /16 como dois octetos de ordem superior da rede e os dois ultimos para endereços de host
  - Classe C:
    - 192.0.0.0/24 a 223.255.255.0/24
    - Comportam redes pequenas, com 254 hosts
    - Usa o Prefixo /24 como tres octetos de ordem superior da rede e o ultimos para endereços de host
  - Classe D
    - 240.0.0.0 a 255.0.0.0
    - Bloco multicast
- O endereço classful foi abandonado em 1990 e substituido pelo classless
  - Atualemnte chamado de Classless Inter-Domain Routing (CIDR)
  - Permite que os clientes recebam endereços IPv4 e qualquer mascara de sub-rede com o numero necessarui de hosts
      - A mascara de sub-rede se torna flexivel


### Endereço de IPv4 Privado

- IPv4 Publicos se tratam de IPs rotados globalente pelos provedores de internet.
- IPv4 Pricado se trata de blocos de endereço que são utilizados para atribuir endereços IPv4 à hosts Internos
- São reservados e só podem ser usados na rede interna
- Esses enderços não são permitdos na internet, sendo descatados pelos roteadores
- Normalmente, os IPs Privados são convertidos em IPs publicos pelo roteador que conecta o roteador da rede interna com a rede do provedor de internet
- Roteadores domesticos fazem esse processo. Atribui IPs Privados e a interface que o conecta à rede do provedor recebe um IP publico
  - O Processo que converte endereços Privados em Publicos é chamado de NAT (Network Address Translation), que permite tanto que o IPv4 Privado seja convertido em publico, como o oposto tambem.
    - O Roteador sem fio consegue fazer conversões de varios IPv4 Privados em um Unico Publico
    - Mesmo que os hosts possuam IPs Privados, é importante que eles compartilhem de um unico endereço roteavel pela internet que o Roteador fornece
- Processo: Os pacotes são direcionados e passam pelo gateway, o roteador converte o IPv4 de Origem privado no seu proprio IPv4 Publico e envia a solicitação

### Atribuição de IPv4

- Para as empresas terem acessos à internet, elas precisam de endereços publicos atribuidoss
- Os IPs devem ser exclusivos. O seu uso é regulado e separada à cada organização de forma separada (tanto para o IPv4, como o IPv6)
- O controle dos endereços de IPs é feito pelas RIRs, que alocam endereços de IP para as empresas de fornecimento de Internet (ISPs)

### Transmissão Unicast

- Usada para comunicações comunns, host a host, em redes clientes/servidor
- Usam o endereço de destino
- Podem ser roteados  por meio de redes interconectadas
- Possui o endereçamento do IPv4 da origem e destino, mas não é necessario a especificação do tipo da transmissão


### Transmissão Broadcast

- Enviam pacotes para todos os hosts da rede usando um endereço de broadcast da rede
- Pacote contem o IPv4 do destino, contendo apenas 1 no IP (Isso signidica todos os hosts daquela rede)
- Muitos protocolos de rede usam esse metodo
- O host ao receber um broadcast, trata a mensagem como se fosse direcionada à ele
- Pode ocorrer de forma direcionada  ou limitada.
- É importante ser limitado para evitar o excesso do trafego

### Transmissão Multicast

- Um Host envia um unico pacote par aum conjunto de host selecionado
- 224.0.0.9: Endereço multicast usado na versão 2 do Protocolo RIP (Routing Information Protocol) para se comunicar com roteadores RIPv2
- Hosts que recebem os dados multicast, são chamados de clientes multicast
- Os grupos multicast sçao representados por um unico endereço de IPv4 multicast de destino
  - Host processa pacotes endereçados tanto para o endereço multicast, como tambem ao seu endereço unicast alocado

### Designação de Endereços

- os IPv4 podem ser atribuidos de forma estatica ou dinamica
  - Estatica: Administrador Configura Manualmenteas informações de IP do Host (No minimo,insere o IPv4, a mascara de subrede e o gateway padrão) pela janela de Propriedades TCP/IP
      - Uteis para aparelhos que sempre devem estar acessiveis na rede (Servidor, Impressora)
      - Sucetivel à erros de digitação do IP
      - Importante ter uma lista dos IPs Permanentes
  - Dinamica: As Redes Locais recebem seus IPv4 e suas configurações por meio do Protocolo DHCP (Dynamic Host Configuration Protocol)
    - Normalmente é utilizado em grandes redes (para remover o tempo da equipe que colocaria os IPs estaticos manualmente) e pequenas redes (preferem manter a configuração automatica)
    - Os IPs não são reservados ao dispositivo, e sim "alugado" por ele, podendo ser retirado e voltar ao pool para ser reutilizado


### Serviço DHCP

- Os dispositivos se conectam à rede local e soliciatam ao Servidor DHCP local um endereço de IPv4 que é recebido
- Normalmente, em redes maiores, o servidor DHCP é um serviidor local dedicado baseado em um PC. Já em redes menores, ele pode estar localizado no fornecedor de Internet em que o host da rede apenas recebe as configurações direto do provedor.
- Quando se tem o uso de Model ou Roteadores sem fio, eles podema atuar como servidor e cliente DHCP. O Roteador recebe os IPv4 da Distribuidora de Internet e atua como servidor DHCP Local, distribuindo os endereços privados e publicos aos hosts internos
- Inicialmente, um host é configurado como cliente DHCP, e não possui um IPv4. Com isso,obtem as informações do Servidor DHCP (que pode estar na rede Local ou no Fornecedor de Serviços de Internet (ISP)). O servidor DHCP possui uma pool de endereços de IPv4 que podem ser utilizados
  - O servidor pode estar localizado em outra rede, demando roteadores intermediarios que configure e encaminhe as solicitações DHCP
  - Solicitação IPv4: Cliente envia um Broadcast com o Endereço de Destino 255.255.255.255, todos os hosts recebem o quadro DHCP de Braodcast, mas apenas o servidor responde com uma oferta de IPv4 para o Cliente. Caso o host de origem aprove, ele envia uma solicitação DHCP pendindo ao servidor para usar o IPv4, o qual o servidor devolve um autenticação DHCP
- Configurando:
  - Normalmente, os roteadores em redes menores já gerenciam isso. Se não, é necessario acessar a interface grafica de adm do roteador.
    - É possivel definir um endereço inicial, numero de endereço que serão atribuidos e tempo que podem ser modificados
  - É possivel acessar a Tabela Cliente DHCP que diz o nome do cliente e a forma de conexão à rede

### Gateway

- O Roteador fornece o Gateway (De forna estatica ou Dinamica (DHCP)), que permite com que os hosts se comuniquem com outros hosts de redes diferentes
  - Todo Host deve usar o roteador como um gateway para outras redes, com isso, todo host deve saber o IPv4 do roteador
- Quando o roteador é configurado para ser o servido DHCP, é enviado à todos os hosts o endereço de gateway padrão, permitindo com que os host posssam usar o IPv4 para enviar mensagens aos hosts conectados no ISP (Fornecedor de Internet) e acessar os Hosts na Internet
  - Normalmente, roteadores sem Fio são servidores DHCP por padrão
    - Quando eles são configurados como Servidor DHCP, eles fornecem o Proprio IPv4 como gateway padrão, mascara de subrede e seu IPv4 aos clientes DHCP

### IPv6

- Com a evolução da Internet, os numeros de IPv4 não seriam suficiente sára todos os sesus usurios. Com isso, em 1995 publicaram a primeira especificação do IPv6.
- Ele possui 128 Bit (16 Bytes), possuindo um tamanho maior que o IPv4 (32 Bit), alocando mais endereços de IPs
- É possivel que ele coexista com o IPv4, porem a tendencia é dele substituir
- Beneficios IPv:
  - A não necessidade do NAT, uma vez que o dispositivo terá seu proprio endereço roteavel globalmente
  - Simplificação an adminsitração e configuração de endereços
- O IPv4 só continua sendo usado por conta que ainda funciona de forma adequada e ocorrem melhorias em seus protocolos e usabilisade.
  - NAT: O IPv4 incluia IPs Privados, que ao fazer solicitações globais, varios computadores da mesma rede usavam o mesmo IP Global
- Os Fornecedores de Internet tem adotado o uso de IPv6 pela alta demanada de endereços de IPs
  - Com a utilização de IoT, provavelmente favorecerá a utilização do IPv6
- Configuração Automatica de Endereço: A SLAAC (Configuração Automatica de Endereço Stateless) permite que um host crie seu endereço rotavel (IP Publico/Global) sem a necessidade de um Servidor DHCP.
  - Host recebe o Prefixo (Endereço da Rede),
 comprimento do prefixo (mascara de sub-rede) e o gateway padrão da mensagem de anuncio do roteador.
  - Host cria sua ID e concede à si um endereço unicast global roteavel
- Endereço Local de Link: Usado para comunicar com dispositivos na mesma rede

### Formatação IPv6

- Apenas há a adição de 1 e 0 nos endereços de origem e destino
- São escritos como um String com valores hexadeciamais que facilitam a legibilidade
- Duas regras que ajudam a reduzir numero de zeros no Endereço IPv6
  - Pode Omitir os 0 à esquerda em qualquer sessão
  - Omitir um segmento que só possui 0, transformando esse segmento em dois-pontos em dobro (::). Só pode ser usado uma vez no endereço

> Continuar 4.5.2.4