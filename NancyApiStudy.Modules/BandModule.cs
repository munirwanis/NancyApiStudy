using Nancy;
using Nancy.ModelBinding;
using NancyApiStudy.Entities;
using System.Collections.Generic;


namespace NancyApiStudy.Modules {
    public class BandModule : NancyModule {
        private static List<Band> bands = new List<Band>() {
            new Band {
                Id = 1,
                Name = "The Beatles",
                Musics = new List<string> {
                    "I Wanna Hold Your Hand",
                    "Can't Buy Me Love",
                    "Hard Days Night"
                },
                Members = new List<Member> {
                    new Member {
                        Name = "John Lennon",
                        Instruments = new List<string> {
                            "Vocal",
                            "Guitar"
                        }
                    },
                    new Member {
                        Name = "Ringo Star",
                        Instruments = new List<string> {
                            "Drums",
                            "Vocal"
                        }
                    }
                }
            }
        };

        public BandModule() {
            Get["/"] = parameters => "Hello world!";
            Get["/bands/{id}"] = parameters => bands[parameters.id - 1];
            Post["/bands"] = parameters => {
                var model = this.Bind<Band>();
                bands.Add(model);
                return bands.Count.ToString();
            };
        }
    }
}
