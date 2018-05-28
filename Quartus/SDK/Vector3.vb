Public Structure Vec3

    Public x As Single
    Public y As Single
    Public z As Single

    Public Function Length()
        If x < 0 Then x *= -1
        If y < 0 Then y *= -1
        If z < 0 Then z *= -1
        Return Math.Sqrt(x * x + y * y + z * y)
    End Function

#Disable Warning BC40005 ' Der Member überschattet eine überschreibbare Methode im Basistyp.
    Public Function Tostring() As String
#Enable Warning BC40005 ' Der Member überschattet eine überschreibbare Methode im Basistyp.
        Return (x & " " & y & " " & z)
    End Function

    Public Sub New(_x As Single, _y As Single, _z As Single)
        x = _x
        y = _y
        z = _z
    End Sub

    Public Shared Operator -(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z)
    End Operator

    Public Shared Operator +(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z)
    End Operator

    Public Shared Operator *(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x * vec2.x, vec1.y * vec2.y, vec1.z * vec2.z)
    End Operator

    Public Shared Operator *(vec1 As Vec3, multiplier As Single) As Vec3
        Return New Vec3(vec1.x * multiplier, vec1.y * multiplier, vec1.z * multiplier)
    End Operator

    Public Shared Operator <>(vec1 As Vec3, vec2 As Vec3) As Boolean
        If vec1.x <> vec2.x Or vec1.y <> vec2.y Or vec1.z <> vec2.z Then Return True : Return False
#Disable Warning BC42354 ' Der Operator gibt nicht für alle Codepfade einen Wert zurück.
    End Operator
#Enable Warning BC42354 ' Der Operator gibt nicht für alle Codepfade einen Wert zurück.

    Public Shared Operator =(vec1 As Vec3, vec2 As Vec3) As Boolean
        If vec1.x = vec2.x And vec1.y = vec2.y And vec1.z = vec2.z Then Return True : Return False
#Disable Warning BC42354 ' Der Operator gibt nicht für alle Codepfade einen Wert zurück.
    End Operator
#Enable Warning BC42354 ' Der Operator gibt nicht für alle Codepfade einen Wert zurück.

    Public Shared Operator /(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x / vec2.x, vec1.y / vec2.y, vec1.z / vec2.z)
    End Operator

    Public Shared Operator /(vec1 As Vec3, divisor As Single) As Vec3
        Return New Vec3(vec1.x / divisor, vec1.y / divisor, vec1.z / divisor)
    End Operator
End Structure
