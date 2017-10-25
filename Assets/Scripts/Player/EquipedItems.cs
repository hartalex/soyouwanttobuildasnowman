using UnityEngine;
using System.Collections;

public static class EquipedItems 
{
    private static string hat;
    private static string lefteye;
    private static string righteye;
    private static string nose;
    private static string mouth;
    private static string neck;
    private static string lefthand;
    private static string righthand;

    public static void EquipHat(string val) {
        hat = val;
    }
    public static void EquipLeftEye(string val)
    {
        lefteye = val;
    }
    public static void EquipRightEye(string val)
    {
        righteye = val;
    }
    public static void EquipNose(string val)
    {
        nose = val;
    }
    public static void EquipMouth(string val)
    {
        mouth = val;
    }
    public static void EquipNeck(string val)
    {
        neck = val;
    }
    public static void EquipLeftHand(string val)
    {
        lefthand = val;
    }
    public static void EquipRightHand(string val)
    {
        righthand = val;
    }

    public static string GetHat()
    {
        return hat;
    }
    public static string GetLeftEye()
    {
        return lefteye;
    }
    public static string GetRightEye()
    {
        return righteye;
    }
    public static string GetNose()
    {
        return nose;
    }
    public static string GetMouth()
    {
        return mouth;
    }
    public static string GetNeck()
    {
        return neck;
    }
    public static string GetLeftHand()
    {
        return lefthand;
    }
    public static string GetRightHand()
    {
        return righthand;
    }
}
