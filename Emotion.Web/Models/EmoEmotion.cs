using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmotionHelicon.Web.Models
{
    public class EmoEmotion
    {
        public int Id { get; set; }
        public float Score { get; set; }
        public int EmoFaceID { get; set; }

        public EmoEmotionEnum EmotionType { get; set; }

        public virtual EmoFace Face { get; set; }
    }
}