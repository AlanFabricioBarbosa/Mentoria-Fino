def calc_quadrilateral_area(width, length):
   area = width * length
   return area

print(f"\nA área do quadrilátero é: {calc_quadrilateral_area(5, 2)}")

def calc_quadrilateral_perimeter(width, length):
   perimeter = 2 * (width + length)
   return perimeter

print(f"\nO perímetro do quadrilátero é: {calc_quadrilateral_perimeter(5,6)}")

def calc_triangle_area(base, height):
   area = (base * height) / 2
   return area

print(f"\nA área do triângulo é: {calc_triangle_area(5, 2)}")

def calc_triangle_perimeter(a, b, c):
   perimeter = a + b + c
   return perimeter

print(f"\nO perímetro do triângulo é: {calc_triangle_perimeter(7,9,5)}")

def check_rectangle(top_length, bottom_length, left_side, right_side, angle_01, angle_02, angle_03, angle_04):
   if (
         top_length == bottom_length and
         right_side == left_side and
         angle_01 == angle_02 == angle_03 == angle_04 == 90
      ):
      return True
   else:
      return False

if (check_rectangle(15, 15, 5, 5, 90, 90, 90, 90)):
   print("É um retangulo")
else:
   print("Não é um retangulo")

