
- As redes tem como objetivo fornecer metodos de comunicações e compartilhamento de informações
  - A comunicação é iniciada por meio de uma mensagem enviada de um individio ou dispositivo para outro
  - A comunicação possui 3 Elementos
    - Origem/Remetente da Mensagem: Quem envia a mensagem
    - Destino/Receptor da Mensagem: Quem recebe e interpreta a mensagem
    - Meio/Canal de Trafego da Mensagem: Caminho em que os dados trafegam
- Para um comunicação seja bem sucedida (recebida e interpretada de forma correta), é necessario:
  - Emissor e Recptor Identificados
  - Aceitação das duas partes sobre o Metodo de Comunicação
    - Idioma comum
    - Velocidade/Ritmo de Transmissão
  - Requisitos de Confirmação ou Recepção


### Protocolos

- Definem alguns itens da comunicação da rede local, como Formato, Tamanho e Padrões da Mensagem
- Alguns Atributos dos Protocolos Importantes são:
  - Temporização: O Tempo que determina a velocidade de dados transmitidos na rede. Controla tambem o envio e quantidade de dados de um host
  - Tamanho da Mensagem: Diz respeito ao tamanho de dados que um metodo permite que envie os dados. Quando se mexe com mensagens grandes, elas são divididas em partes menores
  - Encapsulamento: As mesnagens possuem um cabeçalho com algumas informações da mensagem, como o endereço que identifique a origem e destino.
  - Formato da Mensagem: As mensagens possuem um formato ou estrutura especifica. Ele varia conforme o tipo e canal utilizado
  - Codificação: As mensagens são converticas em bits que depois são codificados em ondas, impulsos eletricos ou de luz. O destino ao recebe-la, descodifica e interpreta
  - Padrão da Mensagem: Define o comportamento da mensagem. Algumas mensagens só são enviadas após ter a ultima ter sido recebida
    - Padrões de cominucações são definidos para que as comunicações sigam um padrão e concluam-se com exito.
      - Cada padrão novo aprovado, é registrado em um documento chamado Solicitação de Comentários (RFC). As RFCs de padrões da Internet são gerenciadas pelo IETF (Internet Engineering Task Force)

### Protocolos

- Para comunicações diversas entre hosts, são encessarios diversos protocolos no software e Hardware.
  - Esses protocolos são agrupados em pilhas. Normalmente, os prodtocolos mais externos na pilha, dependem dos serviços dos protocolos inferiores
  - Esses protocolos, permite que cada pilha atue de forma idependente das demais
- Modelo de Protocolo: Se trata da estrutura de um conjunto de protocolo. Ele é responsavel por ilustar como os diferentes protocolos interagem em um conjunto de protocols

### Modelos em Camada

- Eles ajudam a visualizar o funcionamento de diversos protocolos utilizados em uma comunicação
- Nele é representado a operação realizada em cada camada e suas interações
- Vantagens
  - Ajudam à elaborar protocolos, uma vezque eles possuem infromações determinadas das suas atuações em cada camada
  - Estimula a competição, fazendo com que dversos apralhos consigam utiliza-los
  - Permite melhorias tecnologicas em um nível das camadas
  - Fornece um idioma comum para a descrição de funções e habilidades da rede
- Modelo TCP/IP:  Mostra como a interopreação de protocolos que reagem as comunicações da Internet
  - Aplicação: Representa os Dados do Usuario, Controle de Codificação e Dialogo
  - Transporte: Representa as comunicação entre os diferentes dispositivos
  - Internet: Define o melhor caminho pela rede
  - Acesso à rede: Controla os Hardware e meio fisico que forma a rede

### Modelo de Referencia OSI

- Modelo de Referencia: Descreve as Funções que devem ser concluidas em cada camada (deixando de fora como deve ser realizado). Tem como objetivo ajudar e entender as funções e proocessos necessarios para as comunicações da rede
- Divisão (da mais externa para a mais interna)
  -  Camadas Inferiores
    - 1: Fisica: Descreve os meios fisicos/mecanicos/funcionais e dos procedimentos para gerenciar as conexões fisiscas para as comunicações dos dispositivos
      -  Meio Fisico (Cabos, Fios, Ondas), Hubs e Repetidores
      -  Codificação dos Dados
    - 2: Enlace (Link) de Dados (Protocolo DLL): São os metodos para as trocas de dados entre os dispositivos comuns
      -  Placas de Rede e Drives, Switching de Rede e Conectividade WAN
      -  Foramtação de dados para serem interpretados
    -  3: Rede: Fornece os serviços para a troca os dados de rede entre os dispositivos identificados
      -  Endereçamento de IP e Roteamento
    - 4: Transporte: Define os serviços para fragmentar/transferir/reagrupar os dados das comunicações entre os dispotivos comuns
      -  Lista dos Filtros de Firewall, Video e Voz
  -  Camadas Superiores
    -  5: Sessão: Fornece serviços para a camada de apresentação e gerencia a troca de dados
    -  6: Apresentação: Fornece uma representação dos dados tranferidos
    - 7: Aplicação: Fornece a conectivadade ponta a ponta entre a rede de dados
      -  Componentes associados: Reconhecimento de rede, email, clietnes e servidores web, transferencia de arquivos

### Ethernet

- Antes da definição dos padrões de operação dos equipamentos de rede, haviam diversos aparelhos que realizvam conexões entre si, mas sem garentir que funcionariam em conjunto.
- Os Padrões de rede geram as vantagens:
  - Facilidade no Design
  - Simplifica o desenvolvimento
  - Promove a concorrencia
  - Fornece interconexões consistentes
  - Facilitam o treinamento
  - Dão mais opções aos clientes
- Com o tempo, o IEEE (Instituto de Engenheiros Eletricistas e Eletronicos) realiza melhorias na Ethernet. Um exemplo disso é a evolução de 10Mb/s para 10Gb/s no decorrer do tempo
- Quando uma mensagem é enviada, ela possui um endreçamento definido. Dessa forma, os demais dispositivos na rede podem "Ouvir" a mensagem, porem não leem pois não sao os destinatarios
  - Isso é feito por meio das Interfaces de Ethernet em seus endereçamentos unicos, o MAC

#### Encapsulamento

- Cada mensagem dos dispositivos são encapsuladas em um determinado formato (quadro) e enviado pela rede.
  - O Quadro fornece o endereço de destino e origem
  - As mensagens que não são formatadas corretamente, não tem sucesso na comunicação
- Formação dos Quadros
  - Preâmbulo: Padrão que altera entre 1 e 0 utilizado para sincronizar a temporização
  - SFD: Marca o final das informações de tempo e o inicio do quadro
  - Endereço MAC de Destino: Podem ser Unicast (Host Especifico), Multicast (Grupo de Hosts) ou Broadcast (Todos os hosts na rede local)
  - Endereço MAC de Origem
  - Comprimento/Tipo: Pode assumir dois usos diferentes. Pode indicar o protocolo que irá receber os dados ou indicar o numero de bytes de dados que vem no campo seguinte
  - Dados Encapsulados: Se traata das informações que estão sendo enviadas. O tamanho vaira de 46 à 1500 Bytes
  - FCS: Contem 4 Bytes e é criado pelo dispositivo de origem e recalculado pelo de destino para buscar quadros danificados
  - Tamanho maximo do quadro é 1518 bytes
  - Resumo da Formação do Quadro:
    - Preambulo (1 ou 0, usado na Temporização)
    - SFD: Inicio do Quadro
    - Endereço MAC do Dispositivo de Destino
    - Endereço MAC do Dispositivo de Origem
    - Comprimento do dado ou Tipo do Protocolo que irá receber os dados
    - Dados Encapsulados (Informações enviadas)
    - FCS (4 Bytes que são enviados pela origem e recalculado pelo destino buscando quadros danificados)

### Design Hierarquico de Rede

- Redes Ethernet de grande porte, não são tão eficientes e se tornam lentas. Por esse motivo, elas são dividadas em redes menores.
- As redes menores permite que a rede seja mais gerenciavel, fazendo com que o trafego permaneça local
- Comunicações que demandem de outras redes, são levadas à camadas superiores de trafego
  - Mantem uma maior eficiencia e otimização
  - A rede expande conforme necessario
  - Pode haver a inclusão de redes sem afetar o desempenho das redes já existentes
- As redes são divididas em:
  - Camadas de Acesso: Fornece a conexão dos hosts com a Ethernet
  - Camada de Distribuição: Interconecta Redes Menores
  - Camada Central: Fornece uma conexão de alta velocidade entre os dispositivos da cmaada de distribuição (redes menores)
- Com a interconexão dessas redes, é necessario um protocolo de endereçamento dos dispositivos. O mais comum é o IPv4, porem já foi desenvolvido o IPv6 como substituto (mas eles podem coexistirem juntos).


### Endereços

- Endereço Fisico: Se trata do endereçamento MAC. Ele é fixo e que não há alteração com o passar do tempo.
- Endereço Logico:  São os endereços atribuidos aos integrantes da rede local.
  - É dividido em duas partes:
    - Rede: Representa a Rede Local
    - Host: Representa o Individuo na Rede Local

### Gerenciamento da Rede

- O Trafego IP permite que os dispositivos se comuniquem em uma rede. Para isso, é necessario alguns dispositivos:
  - Camada de Acesso
    - Nivel mais basico da rede que fornece a conexão dos hosts com as redes locais.
      - Comunicações entre hosts, arquivos compartilhados e da impressora
    - primeira camada de conexão com a rede Ethernet
    - Utilizada para transmitir mesnagens à outra rede local
    - Permite que os hosts acessem determinados serviços da rede
    - Normalmente são Switches ou Acess Point
  - Camada de Distribuição: Fornce uma conexão para redes separadas, controlando o tipo e quantidade de trafego entre as camadas. Normalmente são Switches melhores e Roteadores
  - Camada Central: 
    - Transmite grandes quantidaqdes de dados entre as redes finais
    - É a camada backbone, uma camada de alta velocidade de conexão que pode possuir camdadas de conexões redundantes que atuam como Backup.
    - Composta por Roteadores e Siwtches de alta qualidade
- Hubs (Camada de Acesso)
  - Aparalhos inicialmente desenvolvidos com a evolução da Ethernet e otimização das interconexões entre os dispositivos
  - Permite a interconexão entre os hosts de uma rede
  - Todos os dispositivos conectados ao Hub compartilham as mensagens enviadas e a largura da banda disponivel.
    - Os aparelhos apenas tem acesso as mensagens que foram destinados para eles
    - Só é permtido enviar uma mensagem de cada vez pelo Hub
      - Caso haja mais de uma mensagem ao mesmo tempo, haverá a colisão. 
      - A colisão torna os dados solicitados ilevgiveis, necessitando de uma retransmissão. Retransmissões excessivas de dados, reduzem e congestionam a rede
- Switches Ethernet (Camada de Acesso)
  - São aparelhos que aceita e decodificam quadros para ler o enderço fisico (MAC) da mensagem
  - Eles possuem uma lista dos endereços MAC e suas portas ativas
    - Quando as mensagens são enviadas, ele verifica se a mensagem está nessa lista. Caso esteja, o switch cira uma conexão exclusiva para os dois hosts se comunicarem.
    - Os demais hosts conectados, não recebm as mensagens ou compartilham da largura da banda.
    - Esse processo suporta comunicações simultaneas, diminuindo os numeros de possiveis colisões
    - Caso uma mensagem seja transmitida para um dispositivo que não está registrado na rede, o switch envia mensagens comparando o enderço (processo chamado de inundação) do dispositivo com o destino da mensagem. Caso encontre o endereço, apenas ele ira conseguir interpretar a mensagem
    - A cada comunicação de origem e destino, os enderços MAC são salvos pelos swicth, ocorrrendo uma atualização dinamica

> Continuar no Topico 3.4.3
