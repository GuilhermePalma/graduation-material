# Capitulo 8: Configurações de Dispositivos CISCO

## Conteudo

> Aguardando Finalização do Capitulo

---

## Resumo

> Aguardando Finalização do Capitulo

---

### Conectividade

- Para redes domesticas, normalmente apenas um roteador sem fio (com algumas conexões cabeadas) já atende à necessidade da rede. Normalmente, esses roteadores podem ser configurados em uma pagina WEB por meio de uma GUI (Graphic User Interface), que facilita e orienta as configurações mais comuns
- Já para Redes Empresariais, os roteadores sem fio não são tão apropriados por causa da alta quantidade de pessoas conectadas
  - Normalmente é utilizado tambem outros aparelhos para as conexões, em que esses dispositivos tem recursos para controlar o fluxo de dados pela rede
- O nivel de inteligencia de um dispositivo pode ser relacionada à sua posição no modelo OSO, dessa forma, quanto mais alto estiver no Modelo OSI, mais inteligente ele será
  - Quando se diz de ``Intelignecia`` nesse contexto, tem relação ao dispositivos analisar o trafego e desvia-lo conforme as informações não disponiveis nas camadas inferiores
    - Ex: Switch da Camada 2 filtra os dados e envia apenas pela porta conectada ao destino
- Com a evolução dos switches e roteadores a difrença entre eles tem se tornado pequena.
  - Switch: Conectividade em redes locais
  - Roteador: Interligação entre redes locais e necessaris para uma rede WAN (Rede de Longa Distancia)
  - Conclusão: Switch é usado para dispositivos na mesma rede e o Roteador interliga varias redes
- Para a conectividade de redes LAN (Local Area Network) pode ser usados outros dispositivos, como:
  - Acess point sem fio: Permite que os Dispositivos (Telefones IP, Computadores e outros) se conectem à rede por meio de uma conexão sem fio
  - Firewall: Proteção contra ameaças da Rede, Segurança, Controle e Contenção da Rede

### Switches

- Quando as portas Ethernet não são sufiecientes para comportar a rede, é legal utilizar um switch para conectar os aparelhos à rede e tambem fazer a conectvidade na camada de acesso.
- Pontos analisados para escolher um Switch:
  - Tipo de Portas/Interface: Deve-se avaliar os tipos das portas disponiveis. Os switches mais baratos suportam apenas fio par-trançado, já os mais caros podem ter conexões de fibra optica, usados para distancias mariores
  - Velocidade: Nos switches, as portas Ethernet podem funcionar em diferentes velocidades, como 10Mb/s, 100Mb/s e 1000Mb/s. Caso o Swtich só tenha portas de até 100Mb/s, caso a conexão com a Internet for maior que  100Mb/s, o aparelho só atuará até 100 Mb/s. Já uma porta 1000Mb/s suporta as 3 velocidades de conexões. Importante lembrar que as Portas Ethernet NICs tambem possuem velocidades de Transmissões, dessa forma, a largura de banda real será a largura de banda comum mais alta entre a NIC do Dispositivo e a Porta Switch
  - Expansibilidade: Os dispositivos podem ser distribuidos em configurações fixas, com os recursos já definidios, e tambem modulares, em que é posssdivel adicionar slotas de expansão para novos modulos. 
  - Gerenciamento: Os mais basicos e baratos não são configurados. Já um switch com o S.O. da Cisco permite o controle e adiçãoi de segurança nas portas, monitoramento de desempenho e alteração das configurações de um dispositivo
- Hardware de um Switch
  - LEDs de Status: Mostra se o sistema está funcionando corretamente e se está conectado à uma fonte de energia
  - Portas Fast Ethernet 10/100 e Gigabit Ethernet 10/100/1000: Portas com uma velocidade de conexão para conectar outros dispositivos
  - Portas SFP (Small Form-Factor Pluggable): Comporta modulos de tranceptores (um receptor e transmissor) de fibra e cobre. Os tranceptores de fibra são compativeis à cabos de fibra optica e os de Cobre com os Cabos CAT5 com RJ-45
  - Porta de Console: Permite a conexão de um computador com o Switch por meio de um cabo RJ-45 para DB-9 para que faça um gerenciamento fora da banda

#### Configurando

- Os Switches já são pre-configurados para operar em uma LAN quando são inicializados, em que quando os dispositivos se conectam as portas encaminham o trafego. Entretantom nenhuma configuração de Segurança está habilitada
- Para configurar um Switch é necessario conectar no Switch o cabo console e iniciar o Switch. Quando ele iniciar, é iniciado o POST (Power On Self Test), que se trata de uma serie de testes para verificar o funcionamento do Switch. Cask esteja tudo certo o SYST LED pisca verde rapidamente, mas se falhar uma luz amarela é acesa, demandando um reparo
- Existem dois modos de de Configurar, Gerenciar e Monitorar os dispositivos de rede:
  - Gerenciamento Fora da Banda: 
    - Necessario que o computador esteja conectado à porta de console do dispositivo de rede e não requer que as conexões da rede local estejam ativas. 
    - Util para configurar inicialmente o dispositivo de rede ou quado a conectividade não está funcionando corretamente.
    - É necessario ter um cliente emulador terminal instalado no terminal e um cabo para fazer a conectividade
  - Gerenciamento em Banda:
    - Utilizado para monitorar e alterar configurações do dispositivo de rede em uma conexão de rede.
    - É necessario que pelo menos um dispositivo esteja conectado e configurado com um Endereço de IP em uma das portas do dispositivo
    - Telnet, HTTP, SSH são alguns dos serviços que podem ser usados para as acessar o disposotivo e fazer o gerenciamento, monitoramente ou alterar configurações

### Arquivos de Configuração dos Dispositivo da Cisco

- Quando um dispositivo da Cisco são iniciados, carregam dois tipos de arquivos na RAM
  - Arquivos de Imagem de IOS: São armazenados na Memoria Flash e facilitam a operação basica dos componentes hardware
  - Arquivo de Configuração de Inicialização: Possui comandos para configurar inicialmente um roteador e criar o arquivo de configuração de execução que é armazenado na RAM. Todas as alterações de configurações são armazenadas no arquivo de configuração atual e executadas imediatamentas pelo IOS
  - Arquivo de Configuração de Execução: É modificado quando o administrador desempenha a configuração do dispositivo. As alterações são feitas no arquivo runnig-config e devem ser salvos na NVRAM (como o Arquivo de Configuração de Inicialização)
- Cisco IOS (Internetwork Operationg System): Software de Sistema usado na maioria dos dispositivos Cesco

### Roteadores

- São basicamente computadores, uma vez que possuem um S.O (Sistema Operacional), uma CPU (Unidade Central de Processamento), Memoria RAM (Memoria de Acesso Aleatorio), Memoria ROM (Memoria Somente Leitura) e Memoria NVRAM (Memoria de Acessoa Aletorio não volatim). 
  - Exigem uma CPU para Executar instruções no sistema, como Inicialização, Roteamento e Funções de Switch
- Possuem 4 Principais Componentes:
  - Portas de Console: Contem duas Portas, uma RJ-45 e outra USB Tipo-B (USB Mini-B)  para a configuração inicial e acesso à Linha de Comando (CLI)
  - Portas LAN: Tambem contem duas portas Gigabit Ethernet para acesso de LAN
  - EHWIC (Slotes de Alta Velocidade da Placa de Interface WAN): São dois Slots de Expansão que permitem a modularidade e flexibilidade do roteador dar suporte à diferentes tipos de portas, como Serial, DSL, Porta Switch e Sem Fio
  - Slots de Armazenamento: Usados para armazenar e dar suporte aos recursos expandidos. Podem suportar cartões de memoria compact flash. Tambem existem duas portas hosts usb para a prteção do recurso de token
    - Os Flahs podem armazenar a alguns arquivos, como a imagem IOS Cisco, Registros, Configurações, HTML, Backup
    - Normalmente apenas o Slot0 sai com o dispositivo de favrica, onde o local instalado é o padrão de inicialização

#### Configurando

- Para a configuração é necessario montar o rodeador, instalar a placa compact flash externa, ligar o Roteador e observar as mensagens de inicialização
- Assim como um Switch Cisco, há varias maneiras de usad a Linha de Comando (CLI) em um roteador. Os mais comuns são:
  - Console: Se trata de uma porta fisica que permite o Acesso Gerenciamento Fora de Banda. Usa uma conexão USB de baixa velocidade em uma conexão direta. 
  - SSH: Permite acessar remotamente uma sessão CLI por meio da interface de rede ativa configurada com um IP valido na rede
  - Porta AUX: Faz o gerenciamnto remoto do roteador usando uma Linha Telefonica e um Modm de Discagem
- Roteadores tem interfaces de Rede para Enviar e Receber pacotes de IP, dessa forma, com a conexão entre diversas redes é necessario que os diferentes tipos de mio fisico e conectores são necessarios
- Processo de Inicialização do Roteador: Executa o POST (Verifica o Hardware) --> Carrega o Bootstrap (obtido da ROM e copiado para a RAM, localizando o IOS) --> Carrega o IOS na RAM (Arquivo de Configuração do Sistema) --> Carrega o Arquivo de Configuração Flash
- IP de Gerencimanto: Definido quando se deseja gerenciar e confiugrar o switch por uma Conexão de Rede. As configurações definidas (Endereço IP, Máscara de Sub-Rede e Gateway Padrão) devem ser inseridas iguais no software do dispositivo qu etará acessando e do switch
  - É interessante atrivuir senhas para o acesso remoto 
  


### Linha de Comando (CLI) - Cisco

- Um programa de Texto que permite a execução de comandos da CiscO IOS de configuração, monitoramento e administração em dispositiovs Cisco
- Pode ser usado por meio de Gerenciamento de Banda ou Fora da Banda
- Os comandos são usados para alterar configurações simples e complexas, exibir status dos processos, e outros. A maioria dos dispositivos Cisco possuem o CLI 
- Pode ser acessado apos a inicialização no Prompt, em que a CLI pode ser usado para comandos da Cisco
- Os comandos são pareceidos para Switches e Roteadores, sendo um sistema amplo de configuração e monitoramento
- Para configurar um dispositivo no pAcket Tracer, interligar os dispositiovs com um cabo ``console``, usando a porta RS do computador e a console do Switch. Entrar no ``Terminal`` do Computador --> ``Ok`` --> Clicar no Switch e entrar na aba CLI --> Digitar os comandos para o Roteador/Switch

### Comandos Primarios

- O Cisco IOS separa o acesso ao gerenciamento do dispositivo em dois modos:
  - Modo EXEC: Seria um modo mais de Visualização Geral
    - Limita os recursos, comandos e a quantidade que eles são executados, mas é suficiente para operações basicas
    - Não permite alteração das configurações do dispositivo
    - É identificado no Prompt CLI por ``>.``
  - Modo EXEC Privilegiado: Modo com mais acesso à funções de alto nivel
    - Utilizado pelos administrados para executar comandos de configurações e configurações globais
    - É Identificado no Prompt CLI por ``#``

#### Comandos

- Sintaxe Geral dos Comandos: ``comando paralavra-chave argumentos``
  - Comando: Uma intrução reconhecida pelo Prompt
  - Palavras Chaves: Chama uma funcionalidade especifica dentro do comando
  - Argumentos: Valores definidos para o comando ou palavra-chave
- Quando se consulta a documentação de um comando, pode ser exibido as seguintes informações:
  - Palavra em Negrito: Indica comandos e Palavras chaves
  - Itálico: Indica o argumentos que será atribuido um valor
  - [ x ]: Indica um elemento (palavra chave ou argumento) opcional 
  - { x }: Indica um elemento (palavra chave ou argumento) obrigatorio
  - { z | y }: Indica que é necessario escolher entre x OU y
  - [x { z | y}]: Indica que o elemento opcional contem uma escolhaobrigatorio caso seja usado
- Um comando pode ser executado a partir da abreviação da sua sintaxe. Entretanto, é necessario que mantenha a sequencia correta das letras e que o comando em questão não seja tambem outro comando
  - Ex: ``configure`` pode ser abreviado para ``conf`` já que é o unico comando que possui essa sequencia de letras. Entretanto, não pode ser abreviado para ``con`` pois existe outros comandos que iniciam com ``con``
- Maneiras de Obter ajuda/documentação de um comando
  - Ajuda Contextual: 
    - Busca comandos disponiveis dentro de cada modo de comando.
    - Pesquisar por meio das letras inicias, grupo de caracteres. 
    - Quando encontrado, é exibido os argumentos e palavras chaves disponiveis para ao comando
    - ``?`` ou ``letras-comando?`` ou ``comando ?``: Comando que na CLI executa a Ajuda Contexual
  - Verificação de Sintexe de Comando:
    - É executado a cada vez que um comando é executado
    - Verifica se a sintaxe do comando é valido, avaliuando da esquerda para a direta
    - Quando o interpretador valida o comando como correto, ele é executado. Entretanto, caso não entenda, fornece um feedback descrevendo o Erro
- Ctrl+Z: Passa de um Modo de Subconfiguração para o modo EXEC Privilegiado

#### Comandos de Acesso
- ``enable``: Habilita o Modo de EXEC Privilegiado (É Identificado no Prompt CLI por ``#``)
- ``disable``: Desabilita o Modo de EXEC Privilegiado (É Identificado no Prompt CLI por ``>.``)
- ``configure terminal``: Abre a Configuração Global do Dispositivo (É Identificado no Prompt CLI por ``Switch(congfig)#``)
  - > Usar Depois do ``enable`` 
  - Nesse modo é possivel usar outros comandos para configurações especificas
- ``exit``: Caso esteja nas Configurações Locais, volta para o Modo de EXEC Privilegiado. Se não, se estiver no modo Modo de EXEC ou EXEC Privilegiado, finaliza as operações do CLI

### Comando de Subconfiguração 

- São executados depois de Executar: ``enbable`` e ``configure terminal``
- Os modos que podem ser feito esses comandos de sub-configuração são:
  - Configuração de Linha: Usa para configurar o acesso ao Console, SSH, Telnet e AUX
  - Configuração de interface Usado para configurar portas do switch e portas/interface no roteador
- Quando se acessa configurações especificas, o nome do Switch/Roteador no prompt muda e assume um avlor que identifica o comando executado. Ex ``witch(config-line)#``
- ``line console 0``: Acessa o modo de subconfiguração da Linha de Configuração 0
- ``interface FastEthernet 0/1`` (Executado depois de ``line console 0``): Acessa o modo de Subconfiguração da porta/interface FastEthernet 0/1
- ``hotname name01``: Define um nome ao dipsoitivo

### Comando Show

- Comando utilizado para "imprimir" e visualizar as informações (configurações, status opercaional, interface do dispositivo) do Dispositivo e Rede
- Esse comando aceita diversas palavras-chaves, como: 
  - show running-config
  - show interfaces
  - show arp
  - show ip route
  - show protocols
  - show version
    - Versão de Software IOS (armazenado em flash)
    - Versão Bootstrap (armazenada em Boot ROM)
    - Tempo de Uso do Sistema – Tempo desde a última Reinicialização
    - Informações de Reinicialização do Sistema – Método de reinicialização (por exemplo, ciclo de energia, travamento)
    - Nome da Imagem do Software – Nome do arquivo do IOS armazenado em flash
    - Tipo de roteador e processador – Número do Modelo e tipo de processador
    - Tipo de Memória e Alocação (compartilhada/principal) – Principal processador RAM e armazenamento em buffer de E/S do pacote compartilhado
    - Interfaces de hardware disponíveis no dispositivo

> Capitulo 8.5 Pendente

---

[<--- Pagina Anterior **(Capitulo 7: Segurança e Vulnerabilidades nas Redes)**](07_Seguranca_Rede.md)

[Proxima Pagina **(Capitulo 9: Testes e Soucionamento de Problemas)** --->](09_Resolucao_Problemas.md)
