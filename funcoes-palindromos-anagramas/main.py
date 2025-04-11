def reverse_word(word):

   if not word:
      return "Palavra não encontrada"

   return word[::-1].lower()

print(f"\nPalavra invertida: {reverse_word('Rua')}")
print(f"\nPalavra invertida: {reverse_word('Python')}")
print(f"\nPalavra invertida: {reverse_word('Plataforma')}")

def palindromic_words(word):

   if not word:
      return "Palavra não encontrada"

   formatted_word = ""

   for character in word:
      if character.isalnum():
         formatted_word = formatted_word + character.lower()

   reversed_formatted = reverse_word(formatted_word)

   if formatted_word == reversed_formatted:
      return True
   else:
      return False

print(f"\nÉ uma palindromo? {palindromic_words('Ovo')}")
print(f"\nÉ uma palindromo? {palindromic_words('Rua')}")
print(f"\nÉ uma palindromo? {palindromic_words('Ana')}")

def anagram_word(word_01, word_02):

   if not word_01 and word_02:
      return "Palavras não encontradas"

   return (sorted(word_01.lower()) == sorted(word_02.lower()))

print(f"\nSão Anagramas? {anagram_word('Amor', 'Roma')}")
print(f"\nSão Anagramas? {anagram_word('Pedra', 'Padre')}")
print(f"\nSão Anagramas? {anagram_word('Remo', 'Toma')}")
