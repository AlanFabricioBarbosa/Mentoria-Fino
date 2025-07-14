# O que é um dominio?
# Dominio é um tema, ou area de conhecimento do qual o nosso sistema irá tratar.

# Dominio: Escola - Gerenciamento de Alunos
# Entidades: 
- Turma
   - Nome = Ano + Periodo
   - Alunos
   - Professor

- Disciplina
   - Nome (Matemática, história)
   - 36h

- Professor
   - Matricula
   - Nome
   - Especialidade
   - Disciplina

- Aluno
   - Matricula
   - Nome
   - Turma
   - Data de nascimento

- Avaliação - prova
   - Disciplina
   - Nota
   - Turma
   - Aluno
   - Professor
   - Data

# Relacionamento entre entidades
- Uma **Turma** pode ter multiplos **Alunos**
- Uma **Turma** tem um **Professor** e uma **Disciplina**
- Um **Professor** pode estar em várias **Turmas**
- Uma **Disciplina** pode ter várias **Avaliações** por **Aluno** 