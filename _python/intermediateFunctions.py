
# x = [ 
#     [5,2,3], #0
#     [10,8,9] #1
# ] 

# students = [
#      {'first_name':  'Michael', 'last_name' : 'Jordan'},
#      {'first_name' : 'John', 'last_name' : 'Rosales'}
# ]
# sports_directory = {
#     'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
#     'soccer' : ['Messi', 'Ronaldo', 'Rooney']
# }
# z = [ {'x': 10, 'y': 20} ]


# # How would you change the value 10 in x to 15?  Once you're done x should then be [ [5,2,3], [15,8,9] ].  
# print(x)
# x[1][0] = 15
# print(x)

# # How would you change the last_name of the first student from 'Jordan' to "Bryant"?
# print(students)

# # last_name
# # 'last_name'

# students[0]['last_name'] = "Bryant"
# print(students)

# # For the sports_directory, how would you change 'Messi' to 'Andres'?
# print(sports_directory)
# sports_directory['soccer'][0] = 'Andres'
# print(sports_directory)

# For x, how would you change the value 20 to 30?

students = [
     {'first_name':  'Michael', 'last_name' : 'Jordan'},
     {'first_name' : 'John', 'last_name' : 'Rosales'},
     {'first_name' : 'Mark', 'last_name' : 'Guillen'},
     {'first_name' : 'KB', 'last_name' : 'Tonel'}
]

def iterateDictionary(iter):
    studentBuilder = ''
    for student in iter:
        # print("line 48", student)
        studentKeeper = []
        for key in student:
            studentKeeper.append(key + ": " + student[key])

            # print("line 50", key)
            # print(student[key])
        stud = ", ".join(studentKeeper)
        studentBuilder += stud
        studentBuilder += "\n"
        # print(studentBuilder[:len(studentBuilder) - 2])
    print(studentBuilder)

# iterateDictionary(students)

def iterateDictionary2(key, iter):
    for student in iter:
        print(student[key])

# iterateDictionary2('first_name', students)
# print('-'*90)
# iterateDictionary2('last_name', students)

dojo = {
   'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
   'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
}

foods = {
   'hot': ['pizza', 'burgers', 'fries', 'burittos', 'tacos', 'fried pickles', 'soup'],
   'cold': ['ice cream', 'sushi', 'pizza', 'cheese', 'yogurt', 'milk']
}

def dojoBuilder(dojo_list):
    for dojo in dojo_list:
        print(len(dojo_list[dojo]), dojo.upper())
        for location in dojo_list[dojo]:
            print(location)

dojoBuilder(dojo)
dojoBuilder(foods)