class Turma:
   def __init__(self,nome, alunos, professor) -> None:
      self.nome = nome
      self.alunos = alunos
      self.professor = professor

turma_1 = Turma(
   nome = "Turma A",
   alunos=["Alice", "Bob", "Alan"],
   professor="Prof. Silva"
)

print(turma_1)
