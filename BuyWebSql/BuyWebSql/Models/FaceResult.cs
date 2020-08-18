using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyWebSql.Models
{
    public class FaceResult
    {
        public string faceId { get; set; }
        public FaceRectangle faceRectangle { get; set; }
        public FaceAttributes faceAttributes { get; set; }
    }

    public class FaceAttributes
    {
        public decimal smile { get; set; }
        public HeadPose HeadPose { get; set; }
        public string gender { get; set; }
        public decimal age { get; set; }
        public FacialHair facialHair { get; set; }
        public string glasses { get; set; }
        public Emotion emotion { get; set; }
        public Blur blur { get; set; }
        public Exposure exposure { get; set; }
        public Noise noise { get; set; }
        public Makeup makeup { get; set; }
        public List<string> accessories { get; set; }
        public Occlusion occlusion { get; set; }
        public Hair hair { get; set; }
    }

    public class Hair
    {
        public decimal bald { get; set; }
        public bool invisible { get; set; }
        public List<HairColor> hairColor { get; set; }
    }
    public class FaceRectangle
    {
        public decimal top { get; set; }
        public decimal left { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
    }
    public class HeadPose
    {
        public decimal pitch { get; set; }
        public decimal roll { get; set; }
        public decimal yaw { get; set; }
    }
    public class FacialHair
    {
        public decimal moustache { get; set; }
        public decimal beard { get; set; }
        public decimal sideburns { get; set; }
    }

    public class Emotion
    {
        public decimal anger { get; set; }
        public decimal contempt { get; set; }
        public decimal disgust { get; set; }
        public decimal fear { get; set; }
        public decimal happiness { get; set; }
        public decimal neutral { get; set; }
        public decimal sadness { get; set; }
        public decimal surprise { get; set; }
    }
    public class Blur
    {
        public string blurLevel { get; set; }
        public decimal value { get; set; }
    }
    public class Exposure
    {
        public string exposureLevel { get; set; }
        public decimal value { get; set; }
    }
    public class Noise
    {
        public string noiseLevel { get; set; }
        public decimal value { get; set; }
    }
    public class Makeup
    {
        public bool eyeMakeup { get; set; }
        public bool lipMakeup { get; set; }
    }
    public class Occlusion
    {
        public bool foreheadOccluded { get; set; }
        public bool eyeOccluded { get; set; }
        public bool mouthOccluded { get; set; }
    }
    public class HairColor
    {
        public string color { get; set; }
        public decimal confidence { get; set; }
    }

}