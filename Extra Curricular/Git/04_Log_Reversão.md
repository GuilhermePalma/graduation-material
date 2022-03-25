# Historico (Log) e Reversão de Commits

### Historico Git e Comando Git Log

- Por meio dos historico é possivel se situar na area de Trabalho do Git
- ``git log``: Traz informações dos Commits do Repositorio
  - Traz o Commit ``HEAD``
  - Traz o SHA1 do Commit, Autor e Email, Data do Commit, Mensagem e Dados do Commit
  - Apertar ":" e "q" para sair do Git Log
- ``git log name-directory-or-file``: Exibe o Log (Ver Dados exibidos acima) de uma Pasta/Diretorio Especifico
- ``git log --oneline``: Traz o Historico de Commit de Foram Resumida
  - Tag ``HEAD``, SHA1 do Commit e a Mensangem Inserida no Commit
- ``git log --graph``: Exibe a movimentação de uma Branch e Commits do Repositorio
- ``gitk``: Abre uma Interface Grafica (GUI - Graphic User Interface) nativa do Windows. Ela exibe de forma Grafica os Dados de Commit, Data, Autor e Arquivos Modificados

### Reverter Commits: Comando Reset

- ``git reset --soft HEAD~1``: Pega o Commit e Retorna os Arquivos à ``Staging Area/Index`` (Onde os Arquivos ficam depois do ``git add``)
  - Quando se Trata do Ultimo commit
- ``git reset --mixed``: Pega o Commit e Retorna os Arquivos ao ``Working Directory`` (Onde os Arquivos ficam após uma alteração)
- ``git reset --hard HEAD~1``
  - É importante ter muita atenção ao utilizar essa Flag
  - Ele Exclui os Codigos Depois do Commit que foi Informado
- Por Padrão, os dois comandos abaixo equivalem ao ``git reset --mixed``
  - ``git reset SHA1``: Desfaz os Commits até o SHA1 informado
  - ``git reset HEAD~1``: Desfaz os Commits, contando do ultimo commit (``HEAD``) até o numero Informado (``~X``)

> Em todos os Casos acima:
>
> Caso o alvo seja o ultimo commit, é possivel omitir o ``HEAD~1``. Entretanto, caso queira desfazer além dele, é possivel informar quantos commits serão desfeitos ou em qual commit será retornado por meio de:
> - ``HEAD~`` + ``numero de commits que serão voltados``
> - ``SHA1`` do Commit

### Reverter Commits: Comando Revert

- Não possui flags (``--something``), e tambem apenas manipula os commits, e não os arquivos
- Ele cria um novo commit informando e revertendo as informações até o Commit Informado
- As Movimentações podem ocorrer por meio de:
  - ``HEAD~`` + ``numero de commits que serão voltados``
  - ``SHA1`` do Commit
- ``git revert HEAD~1``: Cria um Novo Commit dizendo que o Ultimo Commit (``HEAD``) será revertido e realiza a operação de reverção
  - É possivel alterar o Nome do Commit e Descrição
- Utilizar quando se deseja manter o historico feito nos Commits Desfeitos
