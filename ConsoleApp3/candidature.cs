namespace JFF_Test
{
    public class Candidature
    {
        private string participant;
        private int score;

        public Candidature(string participant, int score)
        {
            this.Participant = participant;
            this.Score = score;
        }

        public string Participant
        {
            get
            {
                return participant;
            }

            set
            {
                this.participant = ((string)value).Trim().ToUpper();
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                this.score = value;
            }
        }


        public override string ToString()
        {
            return Participant.ToString() + "\t\t" + Score.ToString();
        }

    }

}