namespace StackOverFlowPost
{
    class Controls
    {
        protected int _upVote;
        protected int _downVote;

        public void UpVote()
        {
            _upVote += 1;
        }

        public void DownVote()
        {
            _downVote -= 1;
        }

    }
}
