using System.Collections.Generic;

namespace NancyApiStudy.Entities {
    public class Band {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Member> Members { get; set; }

        public List<string> Musics { get; set; }
    }
}
