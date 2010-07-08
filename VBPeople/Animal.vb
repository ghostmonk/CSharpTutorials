Public Class Animal
   ' Methods
   Public Sub New(ByVal atype As AnimalType)
      Me.atype = atype
   End Sub

   Public Sub Speak()
      Console.WriteLine("Hello, I am a {0}: {1}", Me.Type, Me.Version)
   End Sub


   ' Properties
   Public ReadOnly Property Type As AnimalType
      Get
         Return Me.atype
      End Get
   End Property

   Public ReadOnly Property Version As String
      Get
         Return "1.0.0.0"
      End Get
   End Property


   ' Fields
   Private atype As AnimalType
End Class

Public Enum AnimalType
   ' Fields
   Lion = 2
   Tiger = 6
   Gorilla = 5
   Elephant = 4
   Walrus = 3
   Crocodile = 7
   Hippo = 1
   Bear = 0
End Enum