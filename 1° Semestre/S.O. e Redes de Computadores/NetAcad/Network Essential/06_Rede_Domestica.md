# Capitulo 6: Rede Domestica

## Conteudo

> Capitulo não Finalizado

--

## Resumo

> Criar Resumo para Esse Capitulo

---

### Conexão sem Fio

- Mobilidade: Conexão mais facil para os dipositivos
- Escalabilidade: É ossivel expandir e contemplar um maior numero de usuarios e/ou are ade cobertura
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
  - Conexões LAN: Utiliza de ambas as Frequencias, seguem um pardão (IEE 802.11) e possui um nivel de potencia maior, gferando um maior alcance e rendimento
- Canais sem Fio:
  - Quando se tem mais aparelhos de transmissões Wi-Fi ou eletronicos domesticos (babas eletronicas) em um mesmo intervalo, acaba afetando o desempenho.
  - Para evitar esse impacto no desempenho, é utilizado de diferentes canais para comnunicações sem fio, dessa forma podendo ter dispositivos de transmissões pertos, mas sem afetar a Transmissão um do Outro
  - Na rede 5GHz é possivel combinar canais para criar um unico canal de banda larga com uma alta taxa de transferencia de dados

### Gerenciamento de Transmissões

- Quandos se trata de uma rede Ethernet, a colisão ocorre quando dois ou mais dispositivos tentam enviar uma mensagem a mesmo tempo
- Redes WLAN, por nã possuirem limites definidos não é detectado essas colisões, por isso, é utilizada da CSMA/CA (Carrier Sense Multiple Access with Collision Avoidance), em que se cria um canla para os dois dispositivos se comunicarem sem que outros interfiram
  - RTS (Request to Send): Inicialmente, um dispositivo solicita um canal para o Acess Point .
  - Caso o canal esteja dispnivel, o Acess Point responde ao dispositivo com uma CTS (Clear to Send)
    - O CTS é transmitido à todos os dispositivos da rede para saberem que o canal está em uso
- Pulgando um cabo na de Ethernet nas Portas LAN e a outra ponta no computador, alem de uma conexão com a Internet, permite com que acesse as configurações do roteador
  - Normalmente, as configuraçõs do roteador já atribui um endereço de UP automaticamente por meio de um servidor DHCP
- É possivel cadastras uma lista com os Endereços MAC permitidos que acessem a rede
  - Isso deixa a rede mais seguram mas reduz sua flexibilidade de conexçoes. Porem, as vezes, é possivel cadastrar um acesso para convidados na rede
- Outra forma de restringir o acesso é criando uma autenticação (Senha) ppara conexão ao SSID

### Protocolos e Padrão das Conexões sem Fio

- O Padrão utilizado nas conexão Sem Fio é determinado pela IEE 802.11, que diz as caracteristicas dos protocolos 
das comunicações. 
- Configurações do Padrão IEE 802.11
  - Modo de Rede: No padrão existe diferntes modos de rede em que os dispositivos podem se conectar. Deifnir um Modo de Rede especifica, determina que dispositivos com outro modo de rede não cnseguiram acessar. Por isso, manter o Modo de Rede no ``Automatico`` faz com que diferentes dispositivos se conectem
  - Nome da Rede (SSID): Identifica a rede para que os Dispositivos se conectem e se comuniquem
  - Canal Padrão: Determina em qual Frequencia a Rede irá funcionar
  - Boradcast de SIID: Determina se o SSID será transmitido para os Dispositivos

- SSID: Uma String (Text) de até 32 Caracteres, enviada nos Cabeçalhos dos Quadros Transmitidos pela WLAN. Ela permite com que as Estações Sem Fio (STA) identifque qual WLAN eles pertencem e com quais dispositivos podem se comunicar.
  - A Transmissão do SSID permite com quie os dispositivos se conectem automaticamente à rede sem fio. Por Padrão, os roteadores fazem transmissões dos seus SSIDs automaticamente
  - Sem o SSID, dificulta com que os aparelhos conectem-se à rede

  > WLAN: Wirelles Local Area Network (Rede Local Wirelles)

- A Wi-Fi Alliance, é uma organização que realiza teste nos diferentes dispositivos que permitem a conexão sem fio. Caso o dispositivo seja aprovado, recebe o simbolo "Wi-Fi"

### ISP

- SIP (Internet Service Provider): Fornecer um link entre a rede domestica e a Internet Global
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
  - Cabo Coaxial
    - Normalmente são utilizados por provedores de TV a cabo. Em que o sinal de Internet é transportado no mesmo cabo que o sinal de TV
    - Possui uma conexão de alta largura de banda
    - Um Modem separa o sinal de Internet e os demais sinais do cabo
  - DSL (Digital Subscriber Line: 
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

---

[<--- Pagina Anterior **(Capitulo 5: Protocolos e Serviços na Internet)**](05_Protocolos_Serviços.md)

[**Home**](README.MD)