using System;
using System.Collections.Generic;
using System.Text;


namespace Chapter5
{
    class Episode_det
    {
        public string series_name, episode_name;
        public int series_no, episode_no;
        public Episode_det()
        {

        }

        public Episode_det(string s1, int n1, int n2 , string s2)
        {
            series_name = s1;
            episode_name = s2;
            series_no = n1;
            episode_no = n2;
        }
        
    }
}
