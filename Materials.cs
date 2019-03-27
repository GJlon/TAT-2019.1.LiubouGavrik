namespace task_Dev_4
{
    class Materials
    {
        protected string guid;
        protected string description;

        public Materials()
        {
            guid = guid.GuidToString();
            description = "Some materials";                                  
        }

        public string GetGUID()
        {
            return guid;
        }

        public override string ToString()
        {
            return description;
        }

        public override bool Equals(object obj)
        {
            if (obj is Materials)
            {
                Materials material = (Materials)obj;
                return (material.GetGUID()).Equals(guid);
            }
            else
            {
                return false;
            }
        }
    }
}
