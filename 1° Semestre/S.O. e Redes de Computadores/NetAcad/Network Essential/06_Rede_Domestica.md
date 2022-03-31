# Capitulo 6: Rede Domestica

## Conteudo

- [Resumo](#resumo)
  - [Conexão sem Fio](#conexão-sem-fio)
  - [Transmissões na Conexão Sem Fio](#transmissões-na-conexão-sem-fio)
  - [Protocolos e Padrão das Conexões sem Fio](#protocolos-e-padrão-das-conexões-sem-fio)
  - [Gerenciamento de Transmissões](#gerenciamento-de-transmissões)
  - [Segurança e Autenticação na Rede sem Fio](#segurança-e-autenticação-na-rede-sem-fio)
  - [ISP](#isp)
    - [Tipos de Conexões](#tipos-de-conexões)
  - [Dispositivos Moveis](#dispositivos-moveis)
  - [Conexões Bluetooth](#conexões-bluetooth)

--

## Resumo

As Conexões Sem Fio, utilizam de ondas eletromagneticas, dividias em frequencias (4.2GHz e 5GHz), que permite o transporte de Informações. Dessa forma, a rede pode ser expandida e compartilhada com os dispositivos que tenham compatibilidade com transmissões sem fio e desprezando com que o dispositivo esteja conectado à cabos ou atrelado à um espaço fisico.

As conexões via Bluetooth exigem menos configurações e despreza a utilização de cabos, sendo encontradas tanto nos hosts, como em aparelhos perifericos, como fones, mause, caixsas de som. Normalmente utiliza a frequencia 2.4GHz, transmitindo e atuando em uma area e velocidade mais baixa que o Wi-Fi.

Já a rede Wirelles (popularmente chamada de Wi-Fi), utiliza de ambas as frequencias, seguindo o Padrão IEE 80.11, tendo um alcance e potencia maior. Normalmente é utilizado um Roteador que possui 2 tipos de porta, a LAN, para conexões de dispositivos na rede via cabo e a Internet, para a conexão com o Link da Operadora/ISP. Para que ocorra a Transmissão sem fio, é utilizado as Antenas do Roteador para a transmissão do Sinal. 

Das configurações do Roteador, o SSID tem destaque. Ele se trata de um Texto de 32 Caracteres que identifica a Rede sem Fio em que o dispositivo tenta se conectar e tambem é enviado no Cabeçalho das Transmissões de Quadros. Outras configurações são: o modo de rede, que define um modo de conexão especifico; o canal padrao, que determina qual frequencia será utilizada, evitando que ocorra queda no desempenho por causa de outros aparelhos que realizem transmissões sem fio; e por fim, o Broadcast do SSID, que controla se o SSID será transmitido.

Para que os dispositivos se comuniquem com a Internet, é necessario o Link fornecido por um ISP (Provedor de Serviço de Internet). Ele se trata de uma conexão de varias redes que contem Roteadores e Switches para gerenciar e direcionar as transmissões da Origem ao Destino. Para que essa conexão ocorra, é utilizada da rede backbone da Internet, em que é fornecida uma alta velocidade de dados e que conectam varias redes de ISP. Normalmente quando se contrata um ISP, é fornecido junto com o Link da Internet um Roteador Wi-Fi, que possuem um Switch para conexões Locais, um Acess Point para conexões sem Fio e um Servidor DHCP para atribuir os IPs.
 
O Link do ISP pode ser fornecido de diversas formas:
- Cabo Coaxial: Uma conexão de alta largura de banda, normalmente fornecido por Provedores de TV a cabo, em que o sinal de Internet e da TV são transmisitidos juntos e depois separados por um modem
- DSL: Tambem é uma conexão de alta largura de banda, que pode ter seu desempenho afetado em relação à distancia da Fornecedora. Possui uma Linha Telefonica com 3 Canais: um para Download de Dados, outro para Chamadas Telefonicas e ultimo para envio e recebimento de Informações. Esses sinais são separados por um modem para a utilização.
- Celular: Utilizado a partir de transmissões da Rede Celular, tendo um desempenho limitido aos recursos da Torre Conectada
- Satelite: Quando não se tem uma conexão de DSL, é uma boa opção. Realiza a conexão com a Internet por meio de Satalites, dessa forma sendo necessario ter uma visão limpa para o satelite e tendo um custo maior
- Conexão Discada (Dial-up): Um modelo de conexão antigo, que fornece uma baixa largura de banda. Nele é utilizada a Linha Telefonica para iniciar a conexão e um modem para acessa-la

Uma rede Wi-Fi pode ser deixada sem um protocolo de autenticação na sua conexão. Entretanto, em redes domesticas ou em empresas, busca-se restringir o acesso de dispositivos externos usando protocolos de Autenticação e Criptografia:
- Autenticação permitindo que apenas os Endereço MACs cadastrados se conectem à rede
- Criptografia WEP que utilizava de uma chave pre-definida de 64 a 128 bits para a criptografia das Informações Transmitidas. Entretanto, não se é mais recomendada pois utiliza de uma chave estatica, que em certos softwares e possivel obter a chave no Trefego da Rede 
- Criptografia WPA2 que segue a mesma ideia de chave de Criptografia WEP, diferenciando apenas na utiliza de uma chave dinamica a cada vez que estabelce uma conexão com o Acess Point. Uma ramificação dessa criptografia é a WAP2-PSK, mais presente em redes domesticas em que sua chave é pre-compartilhada por toda a rede, normalmente sendo a mesma senha de conexão da rede.

A Autenticação e Filtragem pelo Endereço MAC podem ser utilizados em conjunto. Quando isso ocorrer, a autenticação será realizada primeiro. Outras medidas de segurança são: alterar o SSID padrão do Roteador, Desativar a Transmissão do SSID (entretanto, será necessario digitar manualmente o SSID para a conexão da Rede) e configurar a Filtragem de Trafego. Sempre que possivel, colocar uma autenticação e utilizar da Cirptografia WAP2

Assim como nas Redes Ethernet, é necessario protocolos para evitar a perda de informações na rede causadas pelas colisões. Para isso, na Rede WLAN (Wirelles Local Area Network) é utilizado o CSMA/CA (Carrier Sense Multiple Access with Collision Avoidance), em que é criado canais de comunicações exclusivos para que aquela comunicação ocorra. Dessa forma, inicialmente um Dispositivo Solicita ao Acess Point um Canal de comunicação com o Destino (RTS - Request to Send), caso o Destino esteja disponivel, o Acess Point retorna à Origem um CTS (Clear to send) e avisa os demais dispositivos na rede que ambos estão se conectando. Após a transmissão da Mensagem terminar, os dispositivos notificam o Acess Point com um ACK (Acknowledgement).

Assim como nas Redes Wireless, os dispositivos moveis, conforme o Plano Contratado da Operadaora, conseguem se conectar à antena mais proxima e ter acesso à Rede de Dados Moveis. Conforme os recursos da Antena, é possivel que o dispositivo altere entre os tipos de Rede (5G, 4G, 3G, etc) sem a perda de dados. Entretanto, essa conexão tem como desvantagem a baixa velocidade da conexão.

Por fim, quando aparelhos se conectam no mesmo SSID ou nas portas LAN/Ethernet do Roteador, eles podem se comunicar entre si e tambem, ao retornar à area de Cobertura Wi-Fi, normalmente se conectam automaticamente à rede. 

---

### Conexão sem Fio

- Mobilidade: Conexão mais facil para os dipositivos
- Escalabilidade: É possivel expandir e contemplar um maior numero de usuarios e/ou area de cobertura
- Flexibilidade: Conexão a qualquer hora em qualquer lugar
- Economia: O custo dos dispositivos caem junto do ao amadurecimentod a tecnologia
- Tempo de Intalação Reduzido: Um unico aparelho que fornece conectividade à varias pessoas
- Confiabilidade: Suporta quaisquer tipo de ambientes
- Uma conexão mais rapida e segura
- Permite a conexão com a Rede Internet em diversos dispositivos
- Roteadores sem Fio:
  - Possuem 2 Tipos de Portas:
    - Porta Internet: Porta utilizada para conectar o dispositivo a outra Rede. Normalmente é conectada em um modem DSL ou ao cabo utilizado para conectar-se à Internet
    - Portas Ethernet/LAN: Permite que os dispotivos conectados atuem em uma mesma rede
  - As Antenas no Roteador permite com que os dispositivos conectados à rede pelas portas ou pela conexão sem fio atuem em uma mesma rede.

### Transmissões na Conexão Sem Fio

- As conexões sem Fio utilizam de Ondas Eletromagneticas para transpostar dados entre dispositivos
  - As ondas eletromagneticas são divididas em Frequencias. Algumas são licenciadas pelo Governo e só ppodem ser utilizadas com a permissã. Já outras, não é necessario, e normalmente são usadas em produtos de consumo, como o roteador de Wi-Fi
- As ondas 2,4GHz e 5 GHz são utilizadasna Transmissão sem fio, podendo ser:
  - Conexões Bluetooth: Utiliza a Frequencia 2,4GHz, permite com que diversos dispositivos se interconectem (mouse, celulares, fones, etc), mas tendo um curto alcance e baixa velocidade
  - Conexões LAN: Utiliza de ambas as Frequencias, seguem um pardão (IEE 802.11) e possui um nivel de potencia maior, gerando um maior alcance e rendimento
- Canais sem Fio:
  - Quando se tem mais aparelhos de transmissões Wi-Fi ou eletronicos domesticos (babas eletronicas) em um mesmo intervalo, acaba afetando o desempenho.
  - Para evitar esse impacto no desempenho, é utilizado de diferentes canais para comnunicações sem fio, dessa forma podendo ter dispositivos de transmissões pertos, mas sem afetar a Transmissão um do Outro
  - Na rede 5GHz é possivel combinar canais para criar um unico canal de banda larga com uma alta taxa de transferencia de dados

### Protocolos e Padrão das Conexões sem Fio

- O Padrão utilizado nas conexão Sem Fio é determinado pela IEE 802.11, que diz as caracteristicas dos protocolos
das comunicações.
- Configurações do Padrão IEE 802.11
  - Modo de Rede: No padrão existe diferntes modos de rede em que os dispositivos podem se conectar. Deifnir um Modo de Rede especifica, determina que dispositivos com outro modo de rede não cnseguiram acessar. Por isso, manter o Modo de Rede no ``Automatico``/``Modo Misto`` faz com que diferentes dispositivos se conectem
  - Nome da Rede (SSID): Identifica a rede para que os Dispositivos se conectem e se comuniquem
  - Canal Padrão: Determina em qual Frequencia a Rede irá funcionar
  - Broadcast de SIID: Determina se o SSID será transmitido para os Dispositivos

- SSID: Uma String (Text) de até 32 Caracteres, enviada nos Cabeçalhos dos Quadros Transmitidos pela WLAN. Ela permite com que as Estações Sem Fio (STA) identifque qual WLAN eles pertencem e com quais dispositivos podem se comunicar.
  - A Transmissão do SSID permite com que os dispositivos se conectem automaticamente à rede sem fio. Por Padrão, os roteadores fazem transmissões dos seus SSIDs automaticamente
  - É necessario saber o SSID para se conectar à rede

> WLAN: Wirelles Local Area Network (Rede Local Wirelles)

- A Wi-Fi Alliance, é uma organização que realiza teste nos diferentes dispositivos que permitem a conexão sem fio. Caso o dispositivo seja aprovado, recebe o simbolo "Wi-Fi"

### Gerenciamento de Transmissões

- Quandos se trata de uma rede Ethernet, a colisão ocorre quando dois ou mais dispositivos tentam enviar uma mensagem a mesmo tempo
- Redes WLAN, por nã possuirem limites definidos não é detectado essas colisões, por isso, é utilizada da CSMA/CA (Carrier Sense Multiple Access with Collision Avoidance), em que se cria um canal para os dois dispositivos se comunicarem sem que outros interfiram
  - RTS (Request to Send): Inicialmente, um dispositivo solicita um canal para o Acess Point .
  - Caso o canal esteja dispnivel, o Acess Point responde ao dispositivo com uma CTS (Clear to Send)
    - O CTS é transmitido à todos os dispositivos da rede para saberem que o canal está em uso
  - ACK (Acknowledgement): O cliente informa que a transmissão foi finalizada
- Pulgando um cabo na de Ethernet nas Portas LAN e a outra ponta no computador, alem de uma conexão com a Internet, permite com que acesse as configurações do roteador
  - Normalmente, as configuraçõs do roteador já atribui um endereço de UP automaticamente por meio de um servidor DHCP

### Segurança e Autenticação na Rede sem Fio

- Autenticação com Filtro de Endereço MAC:
  - Ao tentar-se conectar à rede, é enviado o endereço MAC do Dispositivo. Quando a Filtragem pelo Endereço MAC está ativo, o Acess Point só permite que os Endereços MACs Cadastrados se conectem
  - Isso deixa a rede mais seguram mas reduz sua flexibilidade de conexçoes. Porem, as vezes, é possivel cadastrar um acesso para convidados na rede
    - O Acesso é apenas restringido ao uso da Internet na Rede de Convidados
- Autenticação de Rede Aberta:
  - Por padrão, não é exigido a autenticação para Conexões sem Fio
  - Utilizado em Redes Publicas
- Criptografia WEP:
  - É responsavel por criptografar os dados que transitam pela rede utilizando uma chave pre-definida de criptografia/descriptografia de 64 ou 128 bits
  - Por ser uma chave estatica, existem Softwares que conseguem obter essa Chave
- Criptografia WPA2
  - Tambem é uma chave de Cirptografia de 64 a 128 bits, só que é gerada dinâmicamente quando se estabelece uma nova conexão com o Acess Point
  - Após o WEP, surgiu o WAP que depois evoluiu para WAP2
- Criptografia WAP2-PSK:
  - Segue o mesmo modelo da WAP2, mas é utiliza em Redes Domesticas. Por conta disso, utiliza de uma chave pré-compartilhada na rede, sendo a senha da Rede
- Quando se tem a Autenticação e a Filtragem de Endereço MAC, primeiro será feito a autenticação
- Tornando uma rede mais Segura:
  - Altere o SSID e Senha Padrão
  - Desativar a Transmissão do SSID
  - Configurar a filtragem de Conexões via Endereço MAC
  - Configurar Criptografia WAP2 e Autenticação
  - Configurar Filtragem de Trafego

### ISP

- ISP (Internet Service Provider): Fornecer um link entre a rede domestica e a Internet Global
  - Os SIP se organizam em uma teia de conexões de fibra optica que possui roteadores e switches que gerenciam/direcionam p fluxo entre o origem/destino
  - Uma conexão direta entre um Computador - Modem - ISP não forence segurança
  - É recomendado utilizar um roteador para conectar um computador e o ISP com segurança
    - Opção mais utilizada, normalmente com Roteadores Wi-Fi
      - Os roteadores Wi-Fi, normalmente possuem um Swtich - para conexões com fio - e um Acess Point para conexões Sem Fio. Tambem fornece um Trafego Seguro para os Hosts Internos
- Podem fornecer mais serviços na contratação (Hospedagenm de Sutem Segurança, Backup)
- O Backbone de Internet é responavel por fornecer eses links de alta velocidade que conetam diversas redes  de provedores de serviços
- O Backbone da Internet fornece uma caminho de alta velocidade que conecta as redes dos provedores de serviços
  - Normalmente são conectados por cabos de Fibra Optica, no subterraneo de cidades ou até mesmo pelos oceanos (Entre Continentes)

#### Tipos de Conexões

- Normalmente, é feito a conexão por um cabo de fibra optica, mas são possiveis outras formas
  - Cabo Coaxial (Internet a Cabo):
    - Normalmente são utilizados por provedores de TV a cabo. Em que o sinal de Internet é transportado no mesmo cabo que o sinal de TV
    - Possui uma conexão de alta largura de banda
    - Um Modem separa o sinal de Internet e os demais sinais do cabo
  - DSL (Digital Subscriber Line):
    - Executado em uma Linha Telefonica com 3 Canais, um para chamadas telefonicas, um canal de downloasds rapidos e um ultimo para enviar/carregare informações
    - Conexão de alta largura de banda, demandando de um modem de alta velocidade que separa o sinal de telefone e Ethernet
    - A qualidade depende principalmente da qualidade da linha telefonica e da proximidade com a companhia telefonica
  - Celular:
    - Utilização da Rede celular para se conectar, normalmente é utilizada por pessoas que estarão se movuimentando
    - Desempenho limitado aos recursos do telefone e torre conectada
    - É cobrado taxas em cima da utilização
  - Satelite:
    - Uma boa alternatica para locais sem acesso à rede DSL
    - É necessaria uma visão limpa para o satelite, em que areas com muitas arvores u contruções podem afetasr
    - Taxa de Instalação e do Equipamente podem ser mais altas
  - Conexão Discada (Dial-up):
    - Opção de Baixo custo que utiliza da Linha Telefonica e do Modem, mas entregando uma conexão de baixa largura de banda, não sendo suficiente para alta taxa de dados
    - O Usuario faz uma ligação ao ISP e se conecta à Internet

### Dispositivos Moveis 

- Permitem que as pessoas não fiquem presas Fisicamente em um local
- O uso do Wi-Fi é mais recomendando por não consomir o plano de dados da operadora e ter um gasto menor de Energia do Dispositivo
- Em alguns lugares é disponibilizado o acesso à rede Wi-Fi, nessas redes é importante tomar allguns cuidados, como:
  - Não enviar dados de Login em Textos não Encriptografados
  - Usar VPN para proteger dados sensiveis
  - Buscar usar redes com a segurança WPA2
- Processo de Conexão: Um dispositivo tenta Conectar-se à uma Rede dentro da sua Area, buscando um Acess Point que esteja transmitindo o SSID e permita a conexão. Caso nenhuma esteja disponivel e seus Dados Moveis (Plano de Dados de Internet da Operadora) estejam ativos, a conexão é alternada para Dados Moveis
  - Na Rede de Dados Moveis, é possivel que ocorra a alternancia entre os tipos de Rede (5G, 4G, 3G, etc). Nesse processo as conexões não são perdidads
- Um celular sempre tenta conectar-se à redes antigas já conectadas
  - Isso só não ocorre quando a "Conexão Automatica" está desativada ou a Transmissão SSID esteja desativada

### Conexões Bluetooth

- Por que Bluetooth ? Conexões Wi-Fi exigem configurações e um Acess Point e conexões cabeadas nem sempre são praticas
- Permite que conecte diferentes dispositivos (até 8) de modo simples, sem muito consumo de energia
- Alguns Perifericos com Bluetooth:
  - Fone de ouvido, Teclado e mouse
  - Controle de Sistema de Som e Auto-Falantes
  - Compartilhamento de Internet: Um dispositivo consegue compartilhar com outro a sua conexão Wi-Fi
- Para a conexão Bluetooth os aparelhos precisam iniciar o radio Bluetooth e iniciar a busca dos dispositivos configurados como detectavel/visivel.
  - Quando o dispositivo está com o Bluetooth detectavel ele enviando dados como: nome, classe de Bluetooth, serviços disponiveis para utilizar e informações tecnicas do Bluetooth
  - Pode ocorrer de solictar o PIN do dispositivo na conexão. Normalmente, ele é armazenado para proximas conexões

---

[<--- Pagina Anterior **(Capitulo 5: Protocolos e Serviços na Internet)**](05_Protocolos_Serviços.md)

[**Home**](README.MD)