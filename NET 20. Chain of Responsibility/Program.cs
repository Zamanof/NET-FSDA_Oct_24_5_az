// Chain of Responsibility - CoR

ICompile compiler = new SyntaxAnalizer()
                            .SetNext(new LexicalAnalizer()
                                        .SetNext(new Linker()));
compiler.Handle();

Console.WriteLine();

ICompile compiler1 = new LexicalAnalizer()
                                        .SetNext(new SomeSuperHandler()
                                                    .SetNext(new Linker()
                                                            .SetNext(new SyntaxAnalizer())));

compiler1.Handle();