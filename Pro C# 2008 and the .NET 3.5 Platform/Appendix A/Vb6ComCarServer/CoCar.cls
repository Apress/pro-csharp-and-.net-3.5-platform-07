VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CoCar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Implements IDriverInfo

Option Explicit

' A COM enum.
Enum CarType
  Viper
  Colt
  BMW
End Enum

' A COM Event.
Public Event BlewUp()

' Member variables.
Private currSp As Integer
Private maxSp As Integer
Private Make As CarType
Private DriverName As String
Private eng As New Engine

' Remember! All Public members
' are exposed by the default interface!
Public Property Get CurrentSpeed() As Integer
  CurrentSpeed = currSp
End Property

Public Property Get CarMake() As CarType
  CarMake = Make
End Property

Public Sub SpeedUp()
  currSp = currSp + 10
  If currSp >= maxSp Then
    RaiseEvent BlewUp  ' Fire event If you max out the engine.
  End If
End Sub

Private Sub Class_Initialize()
  MsgBox "Init COM car"
End Sub

Public Sub Create(ByVal max As Integer, _
  ByVal cur As Integer, ByVal t As CarType)
  maxSp = max
  currSp = cur
  Make = t
End Sub

Private Property Let IDriverInfo_DriverName(ByVal RHS As String)
  DriverName = RHS
End Property
Private Property Get IDriverInfo_DriverName() As String
  IDriverInfo_DriverName = DriverName
End Property

' Return the Engine to the world.
Public Function GetEngine() As Engine
  Set GetEngine = eng
End Function

