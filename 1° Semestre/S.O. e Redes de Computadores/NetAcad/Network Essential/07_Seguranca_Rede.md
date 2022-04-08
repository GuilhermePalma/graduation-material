# Capitulo 7: Segurança e Vulnerabilidades nas Redes

## Conteudo

> Aguardando Fim do Capitulo para Customização

--

## Resumo

> Aguardando Fim do Capitulo para Criação

---

### Formas de Ataques

- O acesso de pessoas mal intencionadas na rede pode trazer algumas consequencias ruins. Alguns dos Objetivos dessas pessoas são:
  - Roubo/Revenda de Informações
  - Alteração/Manipulação/Exclusão de Registros
  - Roubo de Identidade
  - Interrupção no Funcionamento do Sistema
- O acesso pode ser feito de 2 formas
  - Ameaças Externas: Uma pessoa de Fora tenta uma entrada forçada na empresa, utilizando da Internet, Links sem fio ou Servidores Dial-Up
  - Ameaças Internas: Se trata de ataques a partir de um funcionario da propria empresa, em que normalmente, conhece a politica interna e as informações confidenciais. Nem sempre é um ataque intencional, podendo ocorrer a partir de uma contaminação por um virus ou a ação de alguma ameaça de segurança

### Engenharia Social

- Ocorre quando uma pessoa utiliza de tecnicas para influenciar o comportamento da outra, executando comandos ou obtendo informações sensiveis.
-
#### Tecnicas da Engenharia Social

- Pretexting: Um cenario cenario é inventado utilizando informações reais do Usuario
- Phishing: O Invasr se passa por um empresa legitima, enviando emails ou mensagens solicitando a verificação de informações, como senhas e codigos de acesso, para que certas ações não aconteçam
- Vishing/Phishing por telefone: O Invasor deixa uma mensagem de voz se identificando como uma empresa legitima e solicita o retorno da Ligação. Quando o Usuario realiza o retorno, é solicitado e captados os dados usados no "login"


### Ataques no Software

- É possivel utilizar softwares que explore vulnerabilidade ou do não entendimento do usuario para executar ações mal-intesionadas. Alguns tipos são:
  - Virus: Podem ser encontrados em emails, downloads, ou em dispositivos USB. É necessario que o usuario inicie o Virus, após isso, ele pode tanto se replicar, como fazer ações mais danosas ao sistema, como corromper o HD
  - Worms: São semelhantes aos virus, porem conseguem ser executado de maneira independente e  se espalham pelos hosts da rede de forma rapida
  - Cavalo de Troia: Simulam um Software legitimo, mas diferentemente dos demais, não se replicam e tem como objetivo obter os acessos do computador ou danificar-lo

### Ataques de Sobrecarga

#### Ataque DoS

- O invasor buscam interromper ou afetar o funcionamento de um Software fazendo um sobrecarga de requisições. Normalmente isso pode ser feita de:
  - Imundação Sincrona: É enviado varios pacotes com endereços de IPs de Origem validos e o dispositivo acaba se sobrecarregando ao tentar lidar com cada requisição
  - Ping da Morte: Um pacote com o tamanho maior que o maximo (65.535 bytes) permitido por IP são enviados para o dispositivo. Por ser um pacote fora do padrão, o dispositivo pode travar ao tentar processar
- Os ataques podem focar em: um unico ou grupo de computadores, servidores, roteadors e links de rede
- Um ataque é plenajado pensando em:
  - Imundar o sitema ou rede para impedir o fluxo de outros dispositivos
  - Interromper conexões entre os clientes e servidorara impedir o acesso a um serviço
- Como utiliza de um unico endereço de IP é mais facil de isolar e se defender do ataque

#### Ataque DDoS

- É uma forma mais prejudicial, evoluida e em maior escala que o DoS, utilizada para sobrecarregar links de rede com dados desnecessarios.
- Normalmente utiliza de milhares de dispositivos para sobrecarregar um alvo no mesmo instante

#### Ataque de Força Bruta

- Força Bruta: Utiliza de um computador rapido que faza tentatias sucessivas em senhas ou descodificação da criptografia do site. Com isso, gera um trafego excessivo que reduz o desempenho de um recurso ou do software em si

### Coleta de Dados

- Tem como objetivo coletar informações para usar em anuncios, marketings, pesquisas. Não danificam o computador, mas invade a privacidade do Usuario

#### Spyware

- Normalmente são instalados ao baixar um arquivo ou clicando em um Pop-Up e são dificies de serem removidos. Ao coletarem as informações, é possivel obter as informações sensiveis (documentos, dados bancarios) tambem
- Podem reduzir o desempenho do computador, alterar configurações (o que acaba deixnao o computador vulneravel)
- Adware: Uma forma de Spyware usada para obter informações de um usuario baseado nos sites acessados e direcionar para os anuncios. Normalmente é instalada junto com um produto vendido como "gratuito" e inicializa varias paginas com os anuncios direcionados
  - Abre varias apaginas com o anuncio de forma repedntina
  - Afeta a performance no acesso à internet
  - Pode ser desinstalado facilmente

#### Pop-Up e Pop-Unders

- São janelas adicionas que são exibidas ao acessar um site. Não tem como objetivo coletar informações e normalmente são associados ao site acessado.
- Pop-up: Abrerto na frente da pagina do navegador
- Pop-unders: Aberto atras da pagina do navegador

#### Rastreamento de Cookies

- São uma forma de Spyware que armazena informações sobre um usuario quando acesa um site
- Pode ser util quando se customiza/personaliza dados em sites
- Traçam as propagandas conforme as pesquisas realizadas pelo Usuario

#### Span

- Spam: Pode ser anunciantes enviam um anuncio para o maximo possivel de pessoasm, sem que elas tenham concordado ou queiram receber. Isso pode ser realizado por botnet ou bot. Outro exemplo são as Mensagens comuns de Spam, em que é notificado um virus. Muitas vezes os usuarios acreditam no suposto virus e envia para os demais.
  - Isso pode consumir tempo da equipe de tecnologia ao ter que verificar se a amaeça é verdadeira e tambem tem que se tomar cuidado para não encaminhar virus na mensagens, como links suspeitos

### Bot e Botnets

- Bot (Robô):
  - Represnta um host infectado por um software mal-intencionado que é gerenciado por servidores do criador da botnet.
  - Modos de Infecção: Atraves de email (padrão), link web ou instalação de um programa
  - Esses softwares podem afetar a segurança, capturando dados (dados de login, informações financeiras), realizando ataques DoS e infectando outros hosts
- Botnet: Os servidores que gerenciam os bot agem como um centro de comando e controle, com uma rede de dispositivos que podem ser utilizados
  - Normalmente hosts contaminados passa para outros hosts desprotegidos na rede
  - Se aproveitam dos usuarios que mantem os hosts ligados e conectados à internet para utilizar da largura de banda e processamento dos dispositivos inativos

### Proteção dos Hosts

- Estar atento à possiveis ameaças é necessario para que a rede se mantenha segura, implementando login, alterando nomes padrões e de administrador das contas, manter os softwares atualzados, regras de firewall ativas e detecção de invasão.
  - É importante evitar senhas padrões, como aniversarios, nome do animal de estimação ou time favorito
- Alguns sinais de Presença de Virus, Wom ou Cavalo de Troia são:
  - Comortamento anormal no Host
  - Software não responder aos clique e comandos
  - Programas sendo ativados e desativados sozinhos
  - Envio de grandes quantidades de e-mails
  - Uso da CPU Elevado
  - Execução de Processos não Identificados
  - Computador com baixo desempenho ou travas
- Formas de Prevenção e Tratamento de Possiveis ameaças são:
  - Atualizar o Software Antivuros e o Sistema Operacionall
  - Executar o Antivirus regularmente
  - Não encaminhar e-mails suspeitos
  - Não abrir anexos de e-mail que não se conhece
  - Configurar regras para filtrar conteudo de Spam
  - Identificar e Relatar as Fontes do Span
  - Informar as autoridades o abuso de spam

#### Antivirus

- Funciona tanto como uma ferramenta preventina, evitanto a infecção do host, e tambem reativa, removendo a infecção.
- Deve ser instalado em todos os computadores da rede
- Funciona a partir do reconhecimento de ``assinaturas de virus``, que se tratam de padrões dentro dos programas que já foram identificados em outros softwares prejudiciais. É importante manter o Antivirus atualizado para que sempre tenha as ``assinaturas de virus`` mais recentes
- Alguns Serviços que podem ser inclusos:
  - Verificação de E-mail: Verifica os e-mails enviados e recebidos e reconhece spam e anexos estranhos
  - Varredura Dinamica: Verifica os arquivos/software quando são acessados
  - Verredura Programada: Varreduras de virus executadas em intervalos espeicificos. Pode ser especifica quais unidades será verificada ou se será todo o computador
  - Atualizações Automaticas: Verifica se existe novos padrões e caracaracteristicas de virus e baixa regulatmente ou automaticamente
- Os pprogramas e serviçs de antivirus podem ser fornecidos gratuitamentes ou cobrado uma taxa para download

#### Patches e Atualizações

- Um dos metodos usados para acessar os hosts é explorar as vulnerabilidades antigas do software. Manter o Software atualizado implementa as correções de segurança e melhorias.
- Atualizações X Patches: Patches se trata de uma alteração em um pequeno trecho de codigo usado para resolver questões pontuais. Já as atualizações podem incluir mais funcionalidades alem das patches.
  - S.O e Fornecedores de Softwares disponibilizam regularmente atualizações e correções de vulnerabilidades
  - Service Packs: Lançar um conjunto de correções e atualizaçõesm um host.

#### Software Antispam

- Se Trata de Filtros utilizados para verificar e filtrar os e-mails. Quando um e-mail é detectado como spam, ele pode ser exlcuido ou movido à pasta de ``Spam``
  - Esse filtro pode ser tanto de e-mails que contenham spam ou que se comportaram como spam (propagandas)
- Podem ser obtidos por meio de dispositivos individuais, servidores de e-mail, fornecidos pelos ISPs

#### Antispyware e Anti-adware

- Podem ser fornecidos junto a um antivirus e são responsaveis por Detectar e Exluir aplicativos spyware e impedir novas instalações.
- Alguns detectam e excluem cookies e adware (obtem informações de acessos do usuario para abrir paginas com anuncios direcionados)

> Spyware: Responsavel por obter informações do usuario

#### Bloqueadores de pop-ups

Impedem a exibição de pop-upse pop-unders. Normalmente já vem de padrão com os navegadores. Entretanto, é importante lembrar que as vezes os pop-ups são necessarios para alguam operação no site

### Firewall

- No contexto de Tecnologia, signigica algo que impede o trafego indesjado entre areas protegidas da rede
  - Originalmente o termo era sobre uma parede à prova de fogo. Depois se tornou mais ustilizado para uma folha de mteal que separava o motor de um veiculo do compartimento dos passageiros
- Dificulta o acesso não autorizado, possui regras de acesso à rede, protege a rede interna contra ameaças externas
  - Podem bloquear dispositivos externos (pelo endereço de IP) ou negar pacotes de um intervalo de portas ou o trafego de aplicativos especificos (jogos, redes sociais,etc)
- Pode ser instalado nos computadores, dispositivos de rede e servidores
- Firewall de Hardware: É um dispositivo autonomo utilizado para proteger areas da rede sem que não interfira no desempenho do processamento do dispositivo. Permite que passe dois tipos de trafegos pela rede:
  - Respostas a trafegos que iniciaram dentro da propria rede
  - Trafego para uma porta que foi intencionalmente permitida
- Geralmente são executados junto à um Network Address Translation (NAT) que converte um grupo ou apenas um endereço de IP interno em endereço de IPs externo, registrados que podem ser enviados pela Internet
  - Esse processo mantem os IPs internos ocultos para os usuarios externos
- Normalmente os roteadores sem fio possuem um firewall multifuncional, em que é fornecido o NAT, filtragem de sites, aplicativos e IPs. Tambem comportam recursos DMZ
- DMZ (Zona Desmilitarizada): Trata-se de uma atea acessivel por usuarios internos e externos
  - > Do termo: Significa uma area designada entre dois poderes em que a atividade militar é proibida.
  - No quesito de segurança, é mais seguro que redes externas, mas menos seguro que a rede interna
  - Utilizando um Roteador sem Fio e informando ao DMZ um IP Estatico de um Servidor Interno, é possivel conectar hosts externos em uma rede e isolar seu trafego. Esse isolamento seria feito pelo proprio roteador sem fio, que redirecionaria o trafego para o IP definido no DMZ. Dessa forma, os demais hosts internos da rede continuam protegidos pelo firewall.

### Port Forwarding (Encaminhamento de Portas)

- Um metodo baseado em regras de direcionamento de trafego entre dispositivos de redes separadas.
- Metodo mais seguro que o DMZ
- Quando um trafego chega ao roteador, o firewall determina a partir do numero da prota, se ele deve ser emcaminhado para um determinado dispositivo.
  - O numero da prota são o que diferenciam os diferentes tipos de serviços na rede (FTP, HTTP, etc)
  - As regras definidas no firerwall determinam o trafego permitido na LAN (Local Area Network)
  - > Ex: Ao receber o trefego de uma solicitação HTTP (Porta 80), conforme as regras do firewall,ele será direcionado pelo roteador ao dispositivo que atenda à esse recurso

### Port Triggering

- Durante a utilização de softwares e aplicativos pode ser necessario utilizar mais de uma conexão TCP e UDP enquanto o software está ativo. Deixar varias portas abertas para Internet faz com que a segurança do dispositivo fique em risco.
- Port Triggering: Permite que o roteador encaminhe, de forma temporaria, os dados pelas portas TCP e UDP de entrada para um dispositivo especifico.
  - É possivel encaminhar dados para um computador se intervalo de portas estiver configurado para fazer uma requisição de saida
  - As portas só são abertas quando há alguma requisição na porta especifica

---

[<--- Pagina Anterior **(Capitulo 6: Rede Domestica)**](06_Rede_Domestica.md)

[Proxima Pagina **(Capitulo 8: Configurações de Dispositivos CISCO)** --->](08_Configuracao_Dispositivos.md)
