# Capitulo 9: Testes e Soucionamento de Problemas

## Conteudo

> Aguardando Finalização do Capitulo

---

## Resumo

### Soluçao de Problemas da Rede

- Se trata de um processo para identificar, localizar e realizar a correção de problemas. Para isso é preciso seguir uma certa estrutura e para determinar a solução e realizar a documentação duranmte esse processo.
  - A documentação é essencial para manter um registro coerente e que possa ser consultado no futuro em caso de reincidencia, eoconomizando tempo até o reparo. Algumas das Informações que devem constar na Documentação são:
    - Problema Encontrado
    - Etapas que levou à identificação da causa
    - Etapas realizadas para a correção 
- Inicialmente, ao se deparar com um problema é importante deterninar a dimensão da rede afetada. Quando o problema for confirmado, o primeior passo é coletar as informações
- Coleta de Informações:
  - Inicialmente deve-se cperguntar aos usuarios que relatram o problema ou que foram afetados. As perguntas devem focar em sintomas, mesnagens de erros, informações de mudanças nas configurações
  - Em seguida, deve-se reunir informações sobre os dispositivos afetados. Essas informações podem vir do Log do Dispositivo, dados de Hardware e Produção do equipamento, dados da versão e firware utilizados e por ultimo verificar a compatibilidade com os demais Hardware.
  - E por ultimo, obter informações do monitoramento da propria rede 
  - Quanto mais informações obtidas e detalhas, pode ser mais facil de acabar identificando a causa

### Analise do Problemsa

- Para saber por onde iniciar a analise do problema, é necessario escolher como será ogranizado a abordagem do problema.
- Existem 3 Principais abordagens que utiliza o conecito de camadas do modelo OSI, em que a comunicação é divididam o que permite que verifique a integridade de cada camada até encontrar o problema e Isola-lo. As abordagens são:
  - Top-Down (De cima para baixo): 
    - Começa da Camada de Aplicação e vai até a Fisica
      - Analisar quantas pessoas/Serviços estão sendo afetados pelo mesmo Problema
    - Usado para Problemas Simples ou que podem ter relação com um Usuario
    - Caso o problema esteja nas camadas inferiore, terá sido desperdiçado muito tempo nas demais camadas. Entretanto, caso seja algum problema Interno na Aplciação, como um login expirado, o problema pode ser logo resolvido
  - Divide-and-Conquer (Dividir para conquistar):
    - Começa em uma camada uintermediaria e depois trabalha em um sentido (Top-Down ou Bottom-Up)
    - Mais recomendado quando conhece do assunto e os sintomas são precisos
    - É mais rapida que as outras abordagens, mas é necessario ter conhecimento e vivencia na resolução de problemas.
    - Ex: Iniciar verificando as informações das configurações de IP
  - Bottom-Up (De baixo para cima):
    - Inicia na Camada Fisica até chegar na de Aplicação
      - Verifica conexões com fio, verifica tambem as luzes indicando conexões, etc
    - É util em problemas complexos
    - É uma abordagem mais lenta, porem concreta
- Quando se é um profissional expiriente, é possivel que siga uma sequencia propria, verificando erros comuns de usuario, conexões e processos. Muitas vezes, confiam no seu instinto e experiencia e não utiliza muito das tecnicas estruturadas, como avaliação e erro ou sibstituição

#### Avaliação e Erro

- Usa do conehcimento da pessoal para determinar a causa mais provavel deum problema.
- Faz-se suposições logicas com base em experiencias anteriores. Caso a solução não funcione, ele usaráessas informações para a proxima cuasa mais provavel. Esse ciclo é repetido até obter exito
- É um metodo mais rapido, mas depende da habilidade e experiencia da pessoa, podendo gerar suposições incorretas e soluções negligentes

#### Substituição

- Supõe que o problema é causado por um componente especifico do hardware. Ou tambem comparar hardware e situações de trabalho ajuda à identificar irregularidades. A troca da peça defeituosa ou correção do software economiza tempo e restaura a funcionalidade rapidamente
- Quando se trata de um problema de software, é um problema na camada de acsso na rede TCP/IP

> Continuar 9.1.2.2

---

> Conteudo do Capitulo

---

[<--- Pagina Anterior **(Capitulo 8: Configurações de Dispositivos CISCO)**](08_Configuracao_Dispositivos.md)

[**Home**](README.MD)
