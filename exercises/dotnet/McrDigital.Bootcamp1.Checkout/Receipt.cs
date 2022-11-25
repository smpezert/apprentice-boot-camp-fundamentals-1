namespace McrDigital.Bootcamp1.Checkout
{
    public class Receipt
    {
        private string _text = string.Empty;
        private int _aCountdown = 3;
        private int _bCountdown = 2;
        private int _cCountdown = 4;
        private int _dCountdown = 5;
        private int _total;


        public string Text
        {
            get => $"{_text}Total: {_total}";
        }

        public void ScannedA()
        {
            _text = $"{_text}A: 50";
            if (--_aCountdown == 0)
            {
                _text = $"{_text} - 20 (3 for 130)";
                _total += 30;
            }
            else
            {
                _total += 50;
            }

            _text = $"{_text}\n";
        }

        public void ScannedB()
        {
            _text = $"{_text}B: 30";
            if (--_bCountdown == 0)
            {
                _text = $"{_text} - 15 (2 for 45)";
                _total += 15;
            }
            else
            {
                _total += 30;
            }

            _text = $"{_text}\n";
        }

        public void ScannedC()
        {
            _text = $"{_text}C: 20";
            if (--_cCountdown == 0)
            {
                _text = $"{_text} - 10 (4 for 70)";
                _total += 10;
            }
            else
            {
                _total += 20;
            }

            _text = $"{_text}\n";
        }

        public void ScannedD()
        {
            _text = $"{_text}D: 15";
            if (--_dCountdown == 0)
            {
                _text = $"{_text} - 15 (5 for 60)";
                _total += 0;
            }
            else
            {
                _total += 15;
            }

            _text = $"{_text}\n";
        }
    }
}