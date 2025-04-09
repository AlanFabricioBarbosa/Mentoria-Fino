word_list = [
   "Computador", 
   "Programação", 
   "Desenvolvimento", 
   "Python", 
   "Algoritmo", 
   "Tecnologia", 
   "Software", 
   "Hardware", 
   "MySQL",
]

def bigger_word(word_list: list):
   if not word_list:
      return "Lista vazia" 

   if len(word_list) == 1:
      return word_list[0]

   bigger = word_list[0]

   for word in word_list[1:]:
      if len(word) > len(bigger):
         bigger = word
   return bigger

def minor_word(word_list: list):
   if not word_list:
      return "Lista vazia"

   if type(word_list) != word_list:
      return Exception('Words is not a list')

   if len(word_list) == 1:
      return word_list[0]

   minor = word_list[0]

   for word in word_list[1:]:
      if len(word) < len(minor):
         minor = word
   return minor

print(f"\nA maior palavra da lista é: {bigger_word(word_list)}")
print(f"\nA menor palavra da lista é: {minor_word(word_list)}")
