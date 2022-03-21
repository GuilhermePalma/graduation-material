# Capitulo 5: Protocolos e Serviços na Internet

### Serviços da Internet

- Formação da URL: Protocolo + Endereço + Arquivo acessado
- Acesso à serviços de emails, mensagems, videos e etc, dependem de protocolos do conjunto TCP/IP para realizar as comunições entre clientes e servidor de forma segura
- DNS (Domain Name System): Transforma Nomes da Internet (Sites) em Endereços de IP
  - Utiliza a POrta 53
  - Recebe a solicitação da conversão do nome em endereço de IP, verifica se o nome e IP está na tabela. Caso não esteja, consulta outro DNS no dominio. Quando reconhece o endereço de IP, as informações são devolvidas ao cliente
- SSH (Secure Shell): Usado no acesso remoto à dispositovos da rede ou serbvidores
- SMTP (Simple Mail Transfer Protocol): Envia mensagens de e-mails e anexos. Inicialmente parte do cliente para servidores e de servidores para servidores de e-mail
- POP (Post Office Protocol) e IMAP (Internet Message Acess Protocol): Usado por clientes de e-mail para recuperar email e anexos a partir de um servidor remoto
- DHCP (Dynamic Host Configuration Protocol): Gera automaticamente enderços de IPs e suas configurações para os dispositivos terem acesso à Internet
- Servidor Web: Transfere os arquivos das paginas Web usando o HTTP
- FTP (File Transfer Protocol): Usado para transferencia de arquivos entre sistemas
  - Normalmente é usado a porta 21 na solicitação, mas ao abrir a conexão, muda para porta 20 do TCP para transferir arquivos
  - Possui softwares de clientes baseados em GUI para uma visualização simples da interface


### Protocolos

- Protoco da Camada de Aplicação: O protocolo HTTP controla as interção servidor web/cliente, definindo o formato das solicitações/respostas e como as mensgens serão transportadas
- Protocolo da Camada de Transporte: O protocolo TCP garante que os pacotes IP sejam enviados de forma confiavel e que todos os que foram perdidos, sejam reenviados
- Protocolodo da Camada de Rede Interconectada: O mais comum é o IP. É  responsavel por captar segmentos foramtdos no TCP e atribuir um enderço logico e encapsular os pacotes para o roteamento até o host de destino
- Camada de Acesso à rede: O Protocolo depende to tipo de mensagem da mensagem enviada e seu metodo de encaminhamento

### TCP e UDP

-  O IP cuida apenas da estrutura, endereço e roteamento de pacots.
- Os Protocolos TCP (Transmission Control Protocol) e UDP (User Datagram Protocol) são utilizados para o transporte das mensagens
  - O Protocolo TCP é usado quando se deseja ter a confirmação do recebimento de uma mensagem. Ele monitora o numero de segmentos enviados e quando a origem não recebe a confirmação dentro de um certo periodo, ele supõe que os segmentos foram perdidos e realiza a transmissão da parte "perdida" novamente
  - TCP é responsavel por reagrupar segmentos e passa-lo para os aplicativos
    - FTP, HTTP são exemplos de aplicativos que utilizam do UTP para a entrega de dados
  - Quando não é necessario ou não se dejsa aguardar até a retransmissão das partes perdidas, é utilizado o UDP
    - Não ocorre a retransmissão de dados
    - Utilizações: Mensagem de Audio, VIdeo, Som, DNS, etc
- Os demais protocolos (HTTP, FTP, DHCP, etc) estão na camada de aplicação, tornando possivel e exibindo o resultado da mensagem

### Numero da Porta da Camada de Transporte

- Por haver diversos protocolos e serviços, eles são identificados por um numero de porta. Esse numero é usado para rastrear conversas entre clientes/servidores
- Asa portas são atribuidas pela ICANN (Internet Corporation for Assigned Names and Numbers) e variam de 1 a 65.535
  - Portas Conhecidas: 1 a 1.023
  - Portas Registradas: 1.024 a 49.151 Podem ser portas de distino ou origem. Podem ser usadas para registrar aplicativos especificos
  - Portas Privadas: 49.152 a 65.535. Normalmente são usadas como portas de origem e podem ser usada por qualquer aplicatico
- Porta de Origem: Numero da Porta gerado de forma dinamica para identificar a origem de uma comunicação
- Porta de destino: O cliente coloca esse numero informando qual serviço será utilizado
- Soquete: União do Endereço do IP e a Porta identificada do Serviço

### Telnet

- Permita que realizassem conexões entre computadores para a manipulação e acesso à linha de comando (CLI)
- Não é mais recomendado por conta da falta de segurança e deve ser utilizado o protocolo SSH
  - Não da suporte a dados criptografados, deixando os dados transportados como texto simples na rede. Já o SSH fornece uma maior autenticação e transporte dos dados criptografados

### Protocolos de E-mail

- SMTP: Usado por um cliente de email para enviar as mensagens para o servidor local. O servidor local decide se o email é destinado à uma caixa de correio local ou em outro servidor
- POP3 (Porta 110): Um servidor compativel com o POP3 recebe e armazena mensagens endereçadas aos usuarios. Quando um cliente se conecta ao servidor, os email são baixados. Por padrão, as mensagens não são mantidas no servidor após o acesso do cliente
- IMAP4 (POrta 143): Clientes IMAP recebe e armazena as mensagens endereçadas à eles, mas mantem as mensagens na caixa de correio do servidor a menos que o usuario decida excluir

### Chamas Telefonicas pela Internet

- Na Internet, usam da Tecnologia Peer-to-peer
- Usa a tecnologia VoIP (Voice over IP): Converte sinais da voz analogica em digital
  - Dados são convertidos, encapsulados e enviados pela rede
- Essa chamada para um telefone normal, demanda de um gateway para acessar a rede publica de telefonia comutada (PSTN)
